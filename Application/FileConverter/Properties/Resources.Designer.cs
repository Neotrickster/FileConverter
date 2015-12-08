﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileConverter.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FileConverter.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C:\Music\Artist\Album\Song.wav.
        /// </summary>
        public static string OuputFileNameTemplateSample {
            get {
                return ResourceManager.GetString("OuputFileNameTemplateSample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (p): input file path
        ///(f): input filename
        ///(o): output extension type
        ///(i): input extension type
        ///(d0): input parent folder
        ///(d1): input sub parent folder
        ///...
        ///use maj for uppercase version
        ///
        ///Special paths:
        ///(p:d): my documents path
        ///(p:m): my music path
        ///(p:v): my videos path
        ///(p:p): my pictures path.
        /// </summary>
        public static string OutputFilePathTemplateHelp {
            get {
                return ResourceManager.GetString("OutputFilePathTemplateHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Define the ratio &apos;file size&apos; versus &apos;video quality&apos;. A lower value will give you a smaller file, a greater value give you a better video quality..
        /// </summary>
        public static string VideoEncodingQualityTooltip {
            get {
                return ResourceManager.GetString("VideoEncodingQualityTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Define the ratio &apos;file size&apos; versus &apos;compression duration&apos;. A slow compression will give you a smaller file (for the same video quality) than a faster compression..
        /// </summary>
        public static string VideoEncodingSpeedTooltip {
            get {
                return ResourceManager.GetString("VideoEncodingSpeedTooltip", resourceCulture);
            }
        }
    }
}
