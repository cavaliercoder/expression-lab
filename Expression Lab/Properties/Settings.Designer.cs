﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Regex_Tool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\b[Rr]eg([Ee]xp?|ular[\\s]+expression)\\b")]
        public string LastPattern {
            get {
                return ((string)(this["LastPattern"]));
            }
            set {
                this["LastPattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Enter a regular expression pattern above and input text here to see the results r" +
            "eturned by the System.Text.RegularExpressions.Regex object.")]
        public string LastInput {
            get {
                return ((string)(this["LastInput"]));
            }
            set {
                this["LastInput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Multiline")]
        public global::System.Text.RegularExpressions.RegexOptions RegexOptions {
            get {
                return ((global::System.Text.RegularExpressions.RegexOptions)(this["RegexOptions"]));
            }
            set {
                this["RegexOptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ColorScheme {
            get {
                return ((string)(this["ColorScheme"]));
            }
            set {
                this["ColorScheme"] = value;
            }
        }
    }
}
