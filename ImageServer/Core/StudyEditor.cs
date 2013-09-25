#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.ClearCanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Collections.Generic;
using System.Xml;
using Macro.Common;
using Macro.Common.Statistics;
using Macro.Common.Utilities;
using Macro.ImageServer.Common.Command;
using Macro.ImageServer.Common.Utilities;
using Macro.ImageServer.Core.Edit;
using Macro.ImageServer.Model;
using Macro.ImageServer.Rules;

namespace Macro.ImageServer.Core
{
	/// <summary>
	/// Class for editing a study. 
	/// </summary>
	public class StudyEditor : IDisposable
	{
		/// <summary>
		/// Represents an event generated by the <see cref="StudyEditor"/> when the study is about to be edited.
		/// </summary>
		public class StudyEditingEventArgs : EventArgs
		{
			private readonly WebEditStudyContext _context;

			public StudyEditingEventArgs(WebEditStudyContext context)
			{
				_context = context;
			}

			public WebEditStudyContext Context
			{
				get { return _context; }
			}
		}

		/// <summary>
		/// Represents an event generated by the <see cref="StudyEditor"/> when the study has been edited.
		/// </summary>
		public class StudyEditedEventArgs : EventArgs
		{
			private readonly WebEditStudyContext _context;

			public StudyEditedEventArgs(WebEditStudyContext context)
			{
				_context = context;
			}

			public WebEditStudyContext Context
			{
				get { return _context; }
			}

		}

		#region Events
		public event EventHandler<StudyEditingEventArgs> StudyEditing
		{
			add { _edittingHandlers += value; }
			remove { _edittingHandlers -= value; }
		}
		public event EventHandler<StudyEditedEventArgs> StudyEdited
		{
			add { _editedHandlers += value; }
			remove { _editedHandlers -= value; }
		}
		#endregion

		#region Private Fields

		private EventHandler<StudyEditingEventArgs> _edittingHandlers;
		private EventHandler<StudyEditedEventArgs> _editedHandlers;
		private IList<IWebEditStudyProcessorExtension> _plugins;

		#endregion

		#region Properties

		public Patient Patient { get; private set; }

		public Study Study { get; private set; }

		public ServerPartition ServerPartition { get; private set; }

		public StudyStorageLocation StorageLocation { get; private set; }

		public string FailureReason { get; set; }

		/// <summary>
        /// Gets the new <see cref="StudyStorageLocation"/> for the study after it is updated.
        /// </summary>
        public StudyStorageLocation NewStorageLocation { get; private set; }

	    #endregion

		#region Constructors
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="thePartition"></param>
		/// <param name="location"></param>
		/// <param name="thePatient"></param>
		/// <param name="theStudy"></param>
		public StudyEditor(ServerPartition thePartition, StudyStorageLocation location, Patient thePatient, Study theStudy)
		{
			FailureReason = string.Empty;
			Platform.CheckForNullReference(thePartition, "thePartition");
			Platform.CheckForNullReference(location, "location");
			Platform.CheckForNullReference(thePatient, "thePatient");
			Platform.CheckForNullReference(theStudy, "theStudy");

			ServerPartition = thePartition;
			StorageLocation = location;
			
            Patient = thePatient;
            Study = theStudy;
            
            // Scrub for invalid characters that may cause a failure when the Xml is generated for the history
		    Patient.PatientId = XmlUtils.XmlCharacterScrub(Patient.PatientId);
            Patient.PatientsName = XmlUtils.XmlCharacterScrub(Patient.PatientsName);
            
            Study.StudyDescription = XmlUtils.XmlCharacterScrub(Study.StudyDescription);
            Study.ReferringPhysiciansName = XmlUtils.XmlCharacterScrub(Study.ReferringPhysiciansName);
            Study.PatientId = XmlUtils.XmlCharacterScrub(Study.PatientId);
            Study.PatientsName = XmlUtils.XmlCharacterScrub(Study.PatientsName);            
		}
		#endregion

		#region Private Methods
		private void OnStudyUpdating(WebEditStudyContext context)
		{
			EventsHelper.Fire(_edittingHandlers, this, new StudyEditingEventArgs(context));
		}

		private void OnStudyUpdated(WebEditStudyContext context)
		{
			EventsHelper.Fire(_editedHandlers, this, new StudyEditedEventArgs(context));
		}

		private void LoadExtensions()
		{
			Platform.Log(LogLevel.Debug, "Loading extensions..");
			WebEditStudyProcessorExtensionPoint ex = new WebEditStudyProcessorExtensionPoint();
			_plugins = CollectionUtils.Select(
								ex.CreateExtensions(),
								(IWebEditStudyProcessorExtension plugin) => plugin.Enabled);

			if (_plugins != null && _plugins.Count > 0)
			{

				Platform.Log(LogLevel.Debug, "{0} extension(s) found:", _plugins.Count);
				foreach (IWebEditStudyProcessorExtension plugin in _plugins)
				{
					plugin.Initialize();
					IWebEditStudyProcessorExtension extension = plugin;
					StudyEditing += ((sender, ev) => extension.OnStudyEditing(ev.Context));
					StudyEdited += ((sender, ev) => extension.OnStudyEdited(ev.Context));
				}
			}
		}
		#endregion

		/// <summary>
		/// Perform the edit.
		/// </summary>
		/// <param name="actionXml">A serialized XML representation of <see cref="SetTagCommand"/> objects</param>
		/// <returns></returns>
		public bool Edit(XmlElement actionXml)
		{
			Platform.Log(LogLevel.Info,
						 "Starting Edit of study {0} for Patient {1} (PatientId:{2} A#:{3}) on Partition {4}",
						 Study.StudyInstanceUid, Study.PatientsName, Study.PatientId,
						 Study.AccessionNumber, ServerPartition.Description);

			LoadExtensions();

            EditStudyWorkQueueDataParser parser = new EditStudyWorkQueueDataParser();
		    EditStudyWorkQueueData data = parser.Parse(actionXml);

			using (ServerCommandProcessor processor = new ServerCommandProcessor("Web Edit Study"))
			{
				// Convert UpdateItem in the request into BaseImageLevelUpdateCommand
				List<BaseImageLevelUpdateCommand> updateCommands = null;
				if (data != null)
				{
					updateCommands = CollectionUtils.Map<Edit.UpdateItem, BaseImageLevelUpdateCommand>(
						data.EditRequest.UpdateEntries,
						delegate(Edit.UpdateItem item)
							{
								// Note: For edit, we assume each UpdateItem is equivalent to SetTagCommand
								return new SetTagCommand(item.DicomTag.TagValue, item.OriginalValue, item.Value);
							}
						);
				}

				UpdateStudyCommand updateStudyCommand =
					new UpdateStudyCommand(ServerPartition, StorageLocation, updateCommands, 
						ServerRuleApplyTimeEnum.SopEdited);
				processor.AddCommand(updateStudyCommand);

				// Note, this command will only insert the ArchiveQueue command if a delete doesn't exist
				processor.AddCommand(new InsertArchiveQueueCommand(ServerPartition.Key, StorageLocation.Key));

			    var context = new WebEditStudyContext
			                      {
			                          CommandProcessor = processor,
			                          EditType = data.EditRequest.EditType,
			                          OriginalStudyStorageLocation = StorageLocation,
			                          EditCommands = updateCommands,
			                          OriginalStudy = Study,
			                          OrginalPatient = Patient,
			                          UserId = data.EditRequest.UserId,
			                          Reason = data.EditRequest.Reason
			                      };

				OnStudyUpdating(context);

				if (!processor.Execute())
				{
					Platform.Log(LogLevel.Error, processor.FailureException, "Unexpected failure editing study: {0}",
					             processor.FailureReason);
					FailureReason = processor.FailureReason;

					return false;
				}

				// reload the StudyStorageLocation
				NewStorageLocation = StudyStorageLocation.FindStorageLocations(StorageLocation.StudyStorage)[0];
				context.NewStudystorageLocation = NewStorageLocation;

				OnStudyUpdated(context);

				if (updateStudyCommand.Statistics != null)
					StatisticsLogger.Log(LogLevel.Info, updateStudyCommand.Statistics);

				return true;
			}
		}

		/// <summary>
		/// Dispose.
		/// </summary>
		public void Dispose()
		{
			if (_plugins == null) return;

			foreach (IWebEditStudyProcessorExtension plugin in _plugins)
			{
				plugin.Dispose();
			}
			_plugins = null;
		}
	}
}
