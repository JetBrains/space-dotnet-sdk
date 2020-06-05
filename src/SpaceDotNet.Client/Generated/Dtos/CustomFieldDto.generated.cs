// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class CustomFieldDto
    {
        private PropertyValue<ExtendedTypeDto> _extendedType = new PropertyValue<ExtendedTypeDto>(nameof(CustomFieldDto), nameof(ExtendedType));
        
        [Required]
        [JsonPropertyName("extendedType")]
        public ExtendedTypeDto ExtendedType { get { return _extendedType.GetValue(); } set { _extendedType.SetValue(value); } }
    
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CustomFieldDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CustomFieldDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get { return _name.GetValue(); } set { _name.SetValue(value); } }
    
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(CustomFieldDto), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key { get { return _key.GetValue(); } set { _key.SetValue(value); } }
    
        private PropertyValue<CFTypeDto> _type = new PropertyValue<CFTypeDto>(nameof(CustomFieldDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public CFTypeDto Type { get { return _type.GetValue(); } set { _type.SetValue(value); } }
    
        private PropertyValue<CFConstraintDto?> _constraint = new PropertyValue<CFConstraintDto?>(nameof(CustomFieldDto), nameof(Constraint));
        
        [JsonPropertyName("constraint")]
        public CFConstraintDto? Constraint { get { return _constraint.GetValue(); } set { _constraint.SetValue(value); } }
    
        private PropertyValue<bool> _required = new PropertyValue<bool>(nameof(CustomFieldDto), nameof(Required));
        
        [Required]
        [JsonPropertyName("required")]
        public bool Required { get { return _required.GetValue(); } set { _required.SetValue(value); } }
    
        private PropertyValue<bool> _private = new PropertyValue<bool>(nameof(CustomFieldDto), nameof(Private));
        
        [Required]
        [JsonPropertyName("private")]
        public bool Private { get { return _private.GetValue(); } set { _private.SetValue(value); } }
    
        private PropertyValue<AccessType?> _access = new PropertyValue<AccessType?>(nameof(CustomFieldDto), nameof(Access));
        
        [JsonPropertyName("access")]
        public AccessType? Access { get { return _access.GetValue(); } set { _access.SetValue(value); } }
    
        private PropertyValue<CFValueDto> _defaultValue = new PropertyValue<CFValueDto>(nameof(CustomFieldDto), nameof(DefaultValue));
        
        [Required]
        [JsonPropertyName("defaultValue")]
        public CFValueDto DefaultValue { get { return _defaultValue.GetValue(); } set { _defaultValue.SetValue(value); } }
    
        private PropertyValue<int> _order = new PropertyValue<int>(nameof(CustomFieldDto), nameof(Order));
        
        [Required]
        [JsonPropertyName("order")]
        public int Order { get { return _order.GetValue(); } set { _order.SetValue(value); } }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CustomFieldDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get { return _archived.GetValue(); } set { _archived.SetValue(value); } }
    
    }
    
}
