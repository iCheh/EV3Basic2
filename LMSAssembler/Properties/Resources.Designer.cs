﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMSAssembler.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LMSAssembler.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на 00 ERROR
        ///01 NOP
        ///02 PROGRAM_STOP        16
        ///03 PROGRAM_START       16 32 32 8
        ///04 OBJECT_STOP         T
        ///05 OBJECT_START        T
        ///06 OBJECT_TRIG         T
        ///07 OBJECT_WAIT         T
        ///08 RETURN
        ///// 09 CALL            
        ///0A OBJECT_END          
        ///0B SLEEP
        ///
        ///0C00 PROGRAM_INFO OBJ_STOP       16 16
        ///0C04 PROGRAM_INFO OBJ_START      16 16
        ///0C16 PROGRAM_INFO GET_STATUS     16 8*
        ///0C17 PROGRAM_INFO GET_SPEED      16 32*
        ///0C18 PROGRAM_INFO GET_PRGRESULT  16 8*
        ///// 0C19 PROGRAM_INFO SET_INSTR      
        ///
        ///0D LABEL        [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string bytecodelist {
            get {
                return ResourceManager.GetString("bytecodelist", resourceCulture);
            }
        }
    }
}
