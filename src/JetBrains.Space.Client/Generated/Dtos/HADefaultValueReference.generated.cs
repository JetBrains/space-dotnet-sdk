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
    public sealed class HADefaultValueReference
         : HADefaultValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_DefaultValue.Reference";
        
        public HADefaultValueReference() { }
        
        public HADefaultValueReference(string paramName)
        {
            ParamName = paramName;
        }
        
        private PropertyValue<string> _paramName = new PropertyValue<string>(nameof(HADefaultValueReference), nameof(ParamName));
        
        [Required]
        [JsonPropertyName("paramName")]
        public string ParamName
        {
            get => _paramName.GetValue();
            set => _paramName.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _paramName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
