// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class OpenEnumCFInputValue
         : CFInputValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "OpenEnumCFInputValue";
        
        public OpenEnumCFInputValue() { }
        
        public OpenEnumCFInputValue(CFEnumValueIdentifier? enumValueIdentifier = null)
        {
            EnumValueIdentifier = enumValueIdentifier;
        }
        
        private PropertyValue<CFEnumValueIdentifier?> _enumValueIdentifier = new PropertyValue<CFEnumValueIdentifier?>(nameof(OpenEnumCFInputValue), nameof(EnumValueIdentifier));
        
        [JsonPropertyName("enumValueIdentifier")]
        public CFEnumValueIdentifier? EnumValueIdentifier
        {
            get => _enumValueIdentifier.GetValue();
            set => _enumValueIdentifier.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _enumValueIdentifier.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
