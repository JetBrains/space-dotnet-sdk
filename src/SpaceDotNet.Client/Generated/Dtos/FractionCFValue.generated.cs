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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class FractionCFValue
         : CFValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "FractionCFValue";
        
        public FractionCFValue() { }
        
        public FractionCFValue(Fraction? value = null)
        {
            Value = value;
        }
        
        private PropertyValue<Fraction?> _value = new PropertyValue<Fraction?>(nameof(FractionCFValue), nameof(Value));
        
        [JsonPropertyName("value")]
        public Fraction? Value
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
