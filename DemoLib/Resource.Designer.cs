﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoLib {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DemoLib.Resource", typeof(Resource).Assembly);
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
        ///   Ищет локализованную строку, похожую на Error. Divide by zero..
        /// </summary>
        internal static string DivideByZero {
            get {
                return ResourceManager.GetString("DivideByZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. Invalid number of arguments. The format is not respected: X operation Y or operation X..
        /// </summary>
        internal static string InvalidNumberOfArguments {
            get {
                return ResourceManager.GetString("InvalidNumberOfArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. The operation is not defined..
        /// </summary>
        internal static string OperationNotDefined {
            get {
                return ResourceManager.GetString("OperationNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. The value is out of range for the double type..
        /// </summary>
        internal static string OutOfRange {
            get {
                return ResourceManager.GetString("OutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. The value of X is out of range for the double type..
        /// </summary>
        internal static string OutOfRangeX {
            get {
                return ResourceManager.GetString("OutOfRangeX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. The value of Y is out of range for the double type..
        /// </summary>
        internal static string OutOfRangeY {
            get {
                return ResourceManager.GetString("OutOfRangeY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Result: {0} = {1}.
        /// </summary>
        internal static string PutResult {
            get {
                return ResourceManager.GetString("PutResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &gt;.
        /// </summary>
        internal static string SignEnter {
            get {
                return ResourceManager.GetString("SignEnter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. Unable to complete the operation..
        /// </summary>
        internal static string UnableCompleteOperation {
            get {
                return ResourceManager.GetString("UnableCompleteOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. Unable to determine the value of X..
        /// </summary>
        internal static string UnableX {
            get {
                return ResourceManager.GetString("UnableX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. Unable to determine the value of Y..
        /// </summary>
        internal static string UnableY {
            get {
                return ResourceManager.GetString("UnableY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error. The value of X is less than 0..
        /// </summary>
        internal static string ValueOfXLessThanZero {
            get {
                return ResourceManager.GetString("ValueOfXLessThanZero", resourceCulture);
            }
        }
    }
}