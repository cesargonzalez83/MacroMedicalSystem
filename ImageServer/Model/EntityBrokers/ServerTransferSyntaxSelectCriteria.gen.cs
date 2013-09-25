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

    public partial class ServerTransferSyntaxSelectCriteria : EntitySelectCriteria
    {
        public ServerTransferSyntaxSelectCriteria()
        : base("ServerTransferSyntax")
        {}
        public ServerTransferSyntaxSelectCriteria(ServerTransferSyntaxSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new ServerTransferSyntaxSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerTransferSyntax", ColumnName="Uid")]
        public ISearchCondition<String> Uid
        {
            get
            {
              if (!SubCriteria.ContainsKey("Uid"))
              {
                 SubCriteria["Uid"] = new SearchCondition<String>("Uid");
              }
              return (ISearchCondition<String>)SubCriteria["Uid"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerTransferSyntax", ColumnName="Description")]
        public ISearchCondition<String> Description
        {
            get
            {
              if (!SubCriteria.ContainsKey("Description"))
              {
                 SubCriteria["Description"] = new SearchCondition<String>("Description");
              }
              return (ISearchCondition<String>)SubCriteria["Description"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerTransferSyntax", ColumnName="Lossless")]
        public ISearchCondition<Boolean> Lossless
        {
            get
            {
              if (!SubCriteria.ContainsKey("Lossless"))
              {
                 SubCriteria["Lossless"] = new SearchCondition<Boolean>("Lossless");
              }
              return (ISearchCondition<Boolean>)SubCriteria["Lossless"];
            } 
        }
    }
}
