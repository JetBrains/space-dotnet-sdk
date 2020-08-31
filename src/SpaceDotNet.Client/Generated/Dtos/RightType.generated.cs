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
    public sealed class RightType
         : IPropagatePropertyAccessPath
    {
        public RightType() { }
        
        public RightType(string typeCode, string title)
        {
            TypeCode = typeCode;
            Title = title;
        }
        
        private PropertyValue<string> _typeCode = new PropertyValue<string>(nameof(RightType), nameof(TypeCode));
        
        [Required]
        [JsonPropertyName("typeCode")]
        public string TypeCode
        {
            get { return _typeCode.GetValue(); }
            set { _typeCode.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(RightType), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _typeCode.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
