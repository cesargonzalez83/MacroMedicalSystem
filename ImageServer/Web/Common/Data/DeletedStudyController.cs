#region License

// Copyright (c) 2011, ClearCanvas Inc.
// All rights reserved.
// http://www.ClearCanvas.ca
//
// This software is licensed under the Open Software License v3.0.
// For the complete license, see http://www.ClearCanvas.ca/OSLv3.0

#endregion

using System;
using System.Collections.Generic;
using System.Text;
using Macro.Common;
using Macro.ImageServer.Enterprise;
using Macro.ImageServer.Model;
using Macro.ImageServer.Model.EntityBrokers;
using Macro.ImageServer.Web.Common.Data.Model;

namespace Macro.ImageServer.Web.Common.Data
{
    public class DeletedStudyController
    {
        public void Delete(ServerEntityKey recordKey)
        {
            DeleteStudyRecordAdaptor adaptor = new DeleteStudyRecordAdaptor();
            adaptor.Delete(recordKey);
        }
    }
}
