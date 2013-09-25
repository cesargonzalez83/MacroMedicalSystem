﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.ImageViewer.Clipboard.ImageExport {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class ImageExportSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ImageExportSettings defaultInstance = ((ImageExportSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ImageExportSettings())));
        
        public static ImageExportSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Stores the user&apos;s last chosen exporter (e.g. JPEG).
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Stores the user\'s last chosen exporter (e.g. JPEG).")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Jpg")]
        public string SelectedImageExporterId {
            get {
                return ((string)(this["SelectedImageExporterId"]));
            }
            set {
                this["SelectedImageExporterId"] = value;
            }
        }
        
        /// <summary>
        /// Stores the user&apos;s last selection for how the images should be exported (WYSIWYG vs. Complete).
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Stores the user\'s last selection for how the images should be exported (WYSIWYG v" +
            "s. Complete).")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SelectedImageExportOption {
            get {
                return ((int)(this["SelectedImageExportOption"]));
            }
            set {
                this["SelectedImageExportOption"] = value;
            }
        }
        
        /// <summary>
        /// Specifies how images should be sized (e.g. scaled or fixed dimensions).
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies how images should be sized (e.g. scaled or fixed dimensions).")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Scale")]
        public global::Macro.ImageViewer.Clipboard.ImageExport.SizeMode SizeMode {
            get {
                return ((global::Macro.ImageViewer.Clipboard.ImageExport.SizeMode)(this["SizeMode"]));
            }
            set {
                this["SizeMode"] = value;
            }
        }
        
        /// <summary>
        /// Background color to use when SizeMode is Fixed.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Background color to use when SizeMode is Fixed.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color BackgroundColor {
            get {
                return ((global::System.Drawing.Color)(this["BackgroundColor"]));
            }
            set {
                this["BackgroundColor"] = value;
            }
        }
    }
}
