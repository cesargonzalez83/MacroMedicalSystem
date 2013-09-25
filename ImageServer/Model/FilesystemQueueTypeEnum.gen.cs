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
public partial class FilesystemQueueTypeEnum : ServerEnum
{
      #region Private Static Members
      private static readonly FilesystemQueueTypeEnum _DeleteStudy = GetEnum("DeleteStudy");
      private static readonly FilesystemQueueTypeEnum _PurgeStudy = GetEnum("PurgeStudy");
      private static readonly FilesystemQueueTypeEnum _TierMigrate = GetEnum("TierMigrate");
      private static readonly FilesystemQueueTypeEnum _LosslessCompress = GetEnum("LosslessCompress");
      private static readonly FilesystemQueueTypeEnum _LossyCompress = GetEnum("LossyCompress");
      #endregion

      #region Public Static Properties
      /// <summary>
      /// A record telling when a study is eligible for deletion.  The study will be completely removed from the system.
      /// </summary>
      public static FilesystemQueueTypeEnum DeleteStudy
      {
          get { return _DeleteStudy; }
      }
      /// <summary>
      /// A record telling when a study can be purged from a filesystem.  Only archived studies can be purged.  The study will remain archived and can be restored.
      /// </summary>
      public static FilesystemQueueTypeEnum PurgeStudy
      {
          get { return _PurgeStudy; }
      }
      /// <summary>
      /// A record telling when a study is eligible to be migrated to a lower tier filesystem.
      /// </summary>
      public static FilesystemQueueTypeEnum TierMigrate
      {
          get { return _TierMigrate; }
      }
      /// <summary>
      /// A record telling when a study is eligible for lossless compression and the type of compression to be performed on the study.
      /// </summary>
      public static FilesystemQueueTypeEnum LosslessCompress
      {
          get { return _LosslessCompress; }
      }
      /// <summary>
      /// A record telling when a study is eligible for lossy compression and the type of compression to be performed.
      /// </summary>
      public static FilesystemQueueTypeEnum LossyCompress
      {
          get { return _LossyCompress; }
      }

      #endregion

      #region Constructors
      public FilesystemQueueTypeEnum():base("FilesystemQueueTypeEnum")
      {}
      #endregion
      #region Public Members
      public override void SetEnum(short val)
      {
          ServerEnumHelper<FilesystemQueueTypeEnum, IFilesystemQueueTypeEnumBroker>.SetEnum(this, val);
      }
      static public List<FilesystemQueueTypeEnum> GetAll()
      {
          return ServerEnumHelper<FilesystemQueueTypeEnum, IFilesystemQueueTypeEnumBroker>.GetAll();
      }
      static public FilesystemQueueTypeEnum GetEnum(string lookup)
      {
          return ServerEnumHelper<FilesystemQueueTypeEnum, IFilesystemQueueTypeEnumBroker>.GetEnum(lookup);
      }
      #endregion
}
}
