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
    public partial class PartitionArchive: ServerEntity
    {
        #region Constructors
        public PartitionArchive():base("PartitionArchive")
        {}
        public PartitionArchive(
             ServerEntityKey _serverPartitionKey_
            ,ArchiveTypeEnum _archiveTypeEnum_
            ,String _description_
            ,Boolean _enabled_
            ,Boolean _readOnly_
            ,Int32 _archiveDelayHours_
            ,XmlDocument _configurationXml_
            ):base("PartitionArchive")
        {
            ServerPartitionKey = _serverPartitionKey_;
            ArchiveTypeEnum = _archiveTypeEnum_;
            Description = _description_;
            Enabled = _enabled_;
            ReadOnly = _readOnly_;
            ArchiveDelayHours = _archiveDelayHours_;
            ConfigurationXml = _configurationXml_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ArchiveTypeEnum")]
        public ArchiveTypeEnum ArchiveTypeEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="Description")]
        public String Description
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="Enabled")]
        public Boolean Enabled
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ReadOnly")]
        public Boolean ReadOnly
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ArchiveDelayHours")]
        public Int32 ArchiveDelayHours
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ConfigurationXml")]
        public XmlDocument ConfigurationXml
        { get { return _ConfigurationXml; } set { _ConfigurationXml = value; } }
        [NonSerialized]
        private XmlDocument _ConfigurationXml;
        #endregion

        #region Static Methods
        static public PartitionArchive Load(ServerEntityKey key)
        {
            using (var read = PersistentStoreRegistry.GetDefaultStore().OpenReadContext())
            {
                return Load(read, key);
            }
        }
        static public PartitionArchive Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IPartitionArchiveEntityBroker>();
            PartitionArchive theObject = broker.Load(key);
            return theObject;
        }
        static public PartitionArchive Insert(PartitionArchive entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                PartitionArchive newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public PartitionArchive Insert(IUpdateContext update, PartitionArchive entity)
        {
            var broker = update.GetBroker<IPartitionArchiveEntityBroker>();
            var updateColumns = new PartitionArchiveUpdateColumns();
            updateColumns.ServerPartitionKey = entity.ServerPartitionKey;
            updateColumns.ArchiveTypeEnum = entity.ArchiveTypeEnum;
            updateColumns.Description = entity.Description;
            updateColumns.Enabled = entity.Enabled;
            updateColumns.ReadOnly = entity.ReadOnly;
            updateColumns.ArchiveDelayHours = entity.ArchiveDelayHours;
            updateColumns.ConfigurationXml = entity.ConfigurationXml;
            PartitionArchive newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
