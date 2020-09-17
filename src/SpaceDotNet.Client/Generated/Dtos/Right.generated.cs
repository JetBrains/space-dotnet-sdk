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
    public sealed class Right
         : IPropagatePropertyAccessPath
    {
        public Right() { }
        
        public Right(string typeCode, string code)
        {
            TypeCode = typeCode;
            Code = code;
        }
        
        private PropertyValue<string> _typeCode = new PropertyValue<string>(nameof(Right), nameof(TypeCode));
        
        [Required]
        [JsonPropertyName("typeCode")]
        public string TypeCode
        {
            get { return _typeCode.GetValue(); }
            set { _typeCode.SetValue(value); }
        }
    
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(Right), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get { return _code.GetValue(); }
            set { _code.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _typeCode.SetAccessPath(path, validateHasBeenSet);
            _code.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}