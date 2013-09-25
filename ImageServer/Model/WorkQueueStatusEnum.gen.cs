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
    using System.Collections.Generic;
    using Macro.ImageServer.Model.EntityBrokers;
    using Macro.ImageServer.Enterprise;
    using System.Reflection;

[Serializable]
public partial class WorkQueueStatusEnum : ServerEnum
{
      #region Private Static Members
      private static readonly WorkQueueStatusEnum _Idle = GetEnum("Idle");
      private static readonly WorkQueueStatusEnum _Pending = GetEnum("Pending");
      private static readonly WorkQueueStatusEnum _InProgress = GetEnum("In Progress");
      private static readonly WorkQueueStatusEnum _Completed = GetEnum("Completed");
      private static readonly WorkQueueStatusEnum _Failed = GetEnum("Failed");
      #endregion

      #region Public Static Properties
      /// <summary>
      /// Waiting to expire or for more images
      /// </summary>
      public static WorkQueueStatusEnum Idle
      {
          get { return _Idle; }
      }
      /// <summary>
      /// Pending
      /// </summary>
      public static WorkQueueStatusEnum Pending
      {
          get { return _Pending; }
      }
      /// <summary>
      /// In Progress
      /// </summary>
      public static WorkQueueStatusEnum InProgress
      {
          get { return _InProgress; }
      }
      /// <summary>
      /// The Queue entry is completed.
      /// </summary>
      public static WorkQueueStatusEnum Completed
      {
          get { return _Completed; }
      }
      /// <summary>
      /// The Queue entry has failed.
      /// </summary>
      public static WorkQueueStatusEnum Failed
      {
          get { return _Failed; }
      }

      #endregion

      #region Constructors
      public WorkQueueStatusEnum():base("WorkQueueStatusEnum")
      {}
      #endregion
      #region Public Members
      public override void SetEnum(short val)
      {
          ServerEnumHelper<WorkQueueStatusEnum, IWorkQueueStatusEnumBroker>.SetEnum(this, val);
      }
      static public List<WorkQueueStatusEnum> GetAll()
      {
          return ServerEnumHelper<WorkQueueStatusEnum, IWorkQueueStatusEnumBroker>.GetAll();
      }
      static public WorkQueueStatusEnum GetEnum(string lookup)
      {
          return ServerEnumHelper<WorkQueueStatusEnum, IWorkQueueStatusEnumBroker>.GetEnum(lookup);
      }
      #endregion
}
}
