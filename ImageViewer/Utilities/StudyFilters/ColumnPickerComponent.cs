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

using System.Collections.Generic;
using Macro.Common;
using Macro.Desktop;

namespace Macro.ImageViewer.Utilities.StudyFilters
{
	[ExtensionPoint]
	public sealed class ColumnPickerComponentViewExtensionPoint : ExtensionPoint<IApplicationComponentView> {}

	[AssociateView(typeof (ColumnPickerComponentViewExtensionPoint))]
	public class ColumnPickerComponent : ApplicationComponent
	{
		private readonly List<StudyFilterColumn.ColumnDefinition> _columns;

		public ColumnPickerComponent()
		{
			_columns = new List<StudyFilterColumn.ColumnDefinition>();
		}

		public ColumnPickerComponent(IEnumerable<StudyFilterColumn> columns) : this()
		{
			foreach (StudyFilterColumn column in columns)
			{
				_columns.Add(StudyFilterColumn.GetColumnDefinition(column.Key));
			}
		}

		public IList<StudyFilterColumn.ColumnDefinition> Columns
		{
			get { return _columns; }
		}
	}
}