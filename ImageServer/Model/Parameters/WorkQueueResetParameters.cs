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
using Macro.ImageServer.Enterprise;

namespace Macro.ImageServer.Model.Parameters
{
    public class WorkQueueResetParameters : ProcedureParameters
    {
        public WorkQueueResetParameters()
            : base("ResetWorkQueue") // name of the stored procedure
        { }

        public string ProcessorID
        {
            set { this.SubCriteria["ProcessorID"] = new ProcedureParameter<string>("ProcessorID", value); }
        }

        public int MaxFailureCount
        {
            set { this.SubCriteria["MaxFailureCount"] = new ProcedureParameter<int>("MaxFailureCount", value); }
        }

        public DateTime RescheduleTime
        {
            set { this.SubCriteria["RescheduleTime"] = new ProcedureParameter<DateTime>("RescheduleTime", value); }
        }
        public DateTime FailedExpirationTime
        {
            set { this.SubCriteria["FailedExpirationTime"] = new ProcedureParameter<DateTime>("FailedExpirationTime", value); }
        }

        public DateTime RetryExpirationTime
        {
            set { this.SubCriteria["RetryExpirationTime"] = new ProcedureParameter<DateTime>("RetryExpirationTime", value); }
        }
    
        
    }
}
