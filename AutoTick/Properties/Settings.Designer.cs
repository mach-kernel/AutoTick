﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoTick.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://v5api.phewtick.com/")]
        public string phewtick_server {
            get {
                return ((string)(this["phewtick_server"]));
            }
            set {
                this["phewtick_server"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("meets/scan")]
        public string refresh_tail {
            get {
                return ((string)(this["refresh_tail"]));
            }
            set {
                this["refresh_tail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("meets/meet")]
        public string scan_tail {
            get {
                return ((string)(this["scan_tail"]));
            }
            set {
                this["scan_tail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("users/position")]
        public string location_tail {
            get {
                return ((string)(this["location_tail"]));
            }
            set {
                this["location_tail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-73.976439")]
        public string longitude {
            get {
                return ((string)(this["longitude"]));
            }
            set {
                this["longitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40.688871")]
        public string latitude {
            get {
                return ((string)(this["latitude"]));
            }
            set {
                this["latitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\'America/New_York\'")]
        public string timezone_id {
            get {
                return ((string)(this["timezone_id"]));
            }
            set {
                this["timezone_id"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-0300")]
        public string gmt_offset {
            get {
                return ((string)(this["gmt_offset"]));
            }
            set {
                this["gmt_offset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Phewtick/3.2.0 (iPhone; iOS 5.1.1; Scale/2.00)")]
        public string user_agent {
            get {
                return ((string)(this["user_agent"]));
            }
            set {
                this["user_agent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("application/json")]
        public string header_accept {
            get {
                return ((string)(this["header_accept"]));
            }
            set {
                this["header_accept"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en, zh-Hant, ar, zh-Hans, fr, de, ja, nl, it, es, pt-PT, da, fi, nb, sv, ko, ru, " +
            "pl, pt, tr, uk, hr, cs, el, he, ro, sk, th, id, ms, en-GB, ca, hu, vi, en-us;q=0" +
            ".8")]
        public string header_alang {
            get {
                return ((string)(this["header_alang"]));
            }
            set {
                this["header_alang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool header_keepalive {
            get {
                return ((bool)(this["header_keepalive"]));
            }
            set {
                this["header_keepalive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gzip, deflate")]
        public string header_aencoding {
            get {
                return ((string)(this["header_aencoding"]));
            }
            set {
                this["header_aencoding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("application/x-www-form-urlencoded")]
        public string header_ctype {
            get {
                return ((string)(this["header_ctype"]));
            }
            set {
                this["header_ctype"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string post_bg {
            get {
                return ((string)(this["post_bg"]));
            }
            set {
                this["post_bg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int sleep_time {
            get {
                return ((int)(this["sleep_time"]));
            }
            set {
                this["sleep_time"] = value;
            }
        }
    }
}
