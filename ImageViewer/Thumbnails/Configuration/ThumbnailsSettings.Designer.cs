﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.ImageViewer.Thumbnails.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class ThumbnailsSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ThumbnailsSettings defaultInstance = ((ThumbnailsSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ThumbnailsSettings())));
        
        public static ThumbnailsSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Specifies whether or not to automatically open the thumbnail panel when the viewer opens.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether or not to automatically open the thumbnail panel when the viewe" +
            "r opens.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoOpenThumbnails {
            get {
                return ((bool)(this["AutoOpenThumbnails"]));
            }
            set {
                this["AutoOpenThumbnails"] = value;
            }
        }
    }
}
