﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fype {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class ayarlar : global::System.Configuration.ApplicationSettingsBase {
        
        private static ayarlar defaultInstance = ((ayarlar)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ayarlar())));
        
        public static ayarlar Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool midBut {
            get {
                return ((bool)(this["midBut"]));
            }
            set {
                this["midBut"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SingleJoystick")]
        public string notifyiIconClick {
            get {
                return ((string)(this["notifyiIconClick"]));
            }
            set {
                this["notifyiIconClick"] = value;
            }
        }
    }
}
