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
    public sealed class HATypePrimitiveDto
         : HATypeDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_Type.Primitive";
        
        public HATypePrimitiveDto() { }
        
        public HATypePrimitiveDto(HAPrimitive primitive, bool nullable)
        {
            Primitive = primitive;
            Nullable = nullable;
        }
        
        private PropertyValue<HAPrimitive> _primitive = new PropertyValue<HAPrimitive>(nameof(HATypePrimitiveDto), nameof(Primitive));
        
        [Required]
        [JsonPropertyName("primitive")]
        public HAPrimitive Primitive
        {
            get { return _primitive.GetValue(); }
            set { _primitive.SetValue(value); }
        }
    
        private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypePrimitiveDto), nameof(Nullable));
        
        [Required]
        [JsonPropertyName("nullable")]
        public bool Nullable
        {
            get { return _nullable.GetValue(); }
            set { _nullable.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _primitive.SetAccessPath(path, validateHasBeenSet);
            _nullable.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
