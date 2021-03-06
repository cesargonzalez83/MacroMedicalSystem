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

// This file is auto-generated by the Macro.Model.SqlServer.CodeGenerator project.

namespace Macro.ImageServer.Model
{
    using System;
    using System.Xml;
    using Macro.Enterprise.Core;
    using Macro.ImageServer.Enterprise;
    using Macro.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class StudyDataAccess: ServerEntity
    {
        #region Constructors
        public StudyDataAccess():base("StudyDataAccess")
        {}
        public StudyDataAccess(
             ServerEntityKey _studyStorageKey_
            ,ServerEntityKey _dataAccessGroupKey_
            ):base("StudyDataAccess")
        {
            StudyStorageKey = _studyStorageKey_;
            DataAccessGroupKey = _dataAccessGroupKey_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDataAccess", ColumnName="StudyStorageGUID")]
        public ServerEntityKey StudyStorageKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDataAccess", ColumnName="DataAccessGroupGUID")]
        public ServerEntityKey DataAccessGroupKey
        { get; set; }
        #endregion

        #region Static Methods
        static public StudyDataAccess Load(ServerEntityKey key)
        {
            using (var read = PersistentStoreRegistry.GetDefaultStore().OpenReadContext())
            {
                return Load(read, key);
            }
        }
        static public StudyDataAccess Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IStudyDataAccessEntityBroker>();
            StudyDataAccess theObject = broker.Load(key);
            return theObject;
        }
        static public StudyDataAccess Insert(StudyDataAccess entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                StudyDataAccess newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public StudyDataAccess Insert(IUpdateContext update, StudyDataAccess entity)
        {
            var broker = update.GetBroker<IStudyDataAccessEntityBroker>();
            var updateColumns = new StudyDataAccessUpdateColumns();
            updateColumns.StudyStorageKey = entity.StudyStorageKey;
            updateColumns.DataAccessGroupKey = entity.DataAccessGroupKey;
            StudyDataAccess newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
