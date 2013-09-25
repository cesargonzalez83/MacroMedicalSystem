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
    using Macro.Enterprise.Core;
    using Macro.ImageServer.Enterprise;

    public partial class StudyDataAccessSelectCriteria : EntitySelectCriteria
    {
        public StudyDataAccessSelectCriteria()
        : base("StudyDataAccess")
        {}
        public StudyDataAccessSelectCriteria(StudyDataAccessSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new StudyDataAccessSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDataAccess", ColumnName="StudyStorageGUID")]
        public ISearchCondition<ServerEntityKey> StudyStorageKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("StudyStorageKey"))
              {
                 SubCriteria["StudyStorageKey"] = new SearchCondition<ServerEntityKey>("StudyStorageKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["StudyStorageKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyDataAccess", ColumnName="DataAccessGroupGUID")]
        public ISearchCondition<ServerEntityKey> DataAccessGroupKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("DataAccessGroupKey"))
              {
                 SubCriteria["DataAccessGroupKey"] = new SearchCondition<ServerEntityKey>("DataAccessGroupKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["DataAccessGroupKey"];
            } 
        }
    }
}
