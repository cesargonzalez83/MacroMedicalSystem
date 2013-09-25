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

namespace Macro.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using Macro.ImageServer.Enterprise;

   public class StudyHistoryUpdateColumns : EntityUpdateColumns
   {
       public StudyHistoryUpdateColumns()
       : base("StudyHistory")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="InsertTime")]
        public DateTime InsertTime
        {
            set { SubParameters["InsertTime"] = new EntityUpdateColumn<DateTime>("InsertTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyStorageGUID")]
        public ServerEntityKey StudyStorageKey
        {
            set { SubParameters["StudyStorageKey"] = new EntityUpdateColumn<ServerEntityKey>("StudyStorageKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyHistoryTypeEnum")]
        public StudyHistoryTypeEnum StudyHistoryTypeEnum
        {
            set { SubParameters["StudyHistoryTypeEnum"] = new EntityUpdateColumn<StudyHistoryTypeEnum>("StudyHistoryTypeEnum", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyData")]
        public XmlDocument StudyData
        {
            set { SubParameters["StudyData"] = new EntityUpdateColumn<XmlDocument>("StudyData", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="ChangeDescription")]
        public XmlDocument ChangeDescription
        {
            set { SubParameters["ChangeDescription"] = new EntityUpdateColumn<XmlDocument>("ChangeDescription", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="DestStudyStorageGUID")]
        public ServerEntityKey DestStudyStorageKey
        {
            set { SubParameters["DestStudyStorageKey"] = new EntityUpdateColumn<ServerEntityKey>("DestStudyStorageKey", value); }
        }
    }
}
