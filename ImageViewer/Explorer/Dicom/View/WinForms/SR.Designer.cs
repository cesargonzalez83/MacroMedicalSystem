﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.ImageViewer.Explorer.Dicom.View.WinForms {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Macro.ImageViewer.Explorer.Dicom.View.WinForms.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Cancel 的本地化字符串。
        /// </summary>
        internal static string ButtonCancelSearch {
            get {
                return ResourceManager.GetString("ButtonCancelSearch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Search 的本地化字符串。
        /// </summary>
        internal static string ButtonSearch {
            get {
                return ResourceManager.GetString("ButtonSearch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The list of available Modalities has not yet been set. 的本地化字符串。
        /// </summary>
        internal static string ErrorAvailableModalitiesNotSet {
            get {
                return ResourceManager.GetString("ErrorAvailableModalitiesNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The control cannot have its modalities set multiple times. 的本地化字符串。
        /// </summary>
        internal static string ErrorCannotResetModalities {
            get {
                return ResourceManager.GetString("ErrorCannotResetModalities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ,  的本地化字符串。
        /// </summary>
        internal static string FormatListSeparator {
            get {
                return ResourceManager.GetString("FormatListSeparator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Clear 的本地化字符串。
        /// </summary>
        internal static string ItemClear {
            get {
                return ResourceManager.GetString("ItemClear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 At least one error has occurred while attempting to query the selected server(s). 的本地化字符串。
        /// </summary>
        internal static string MessageErrorQueryingOneOrMoreServers {
            get {
                return ResourceManager.GetString("MessageErrorQueryingOneOrMoreServers", resourceCulture);
            }
        }
    }
}
