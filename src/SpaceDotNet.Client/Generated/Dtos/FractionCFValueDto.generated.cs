// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class FractionCFValueDto
         : CFValueDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "FractionCFValue";
        
        public FractionCFValueDto() { }
        
        public FractionCFValueDto(FractionDto? value = null)
        {
            Value = value;
        }
        
        private PropertyValue<FractionDto?> _value = new PropertyValue<FractionDto?>(nameof(FractionCFValueDto), nameof(Value));
        
        [JsonPropertyName("value")]
        public FractionDto? Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
