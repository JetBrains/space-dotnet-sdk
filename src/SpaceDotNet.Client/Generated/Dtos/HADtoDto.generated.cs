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
    public sealed class HADtoDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(HADtoDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(HADtoDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get { return _name.GetValue(); } set { _name.SetValue(value); } }
    
        private PropertyValue<List<HADtoFieldDto>> _fields = new PropertyValue<List<HADtoFieldDto>>(nameof(HADtoDto), nameof(Fields));
        
        [Required]
        [JsonPropertyName("fields")]
        public List<HADtoFieldDto> Fields { get { return _fields.GetValue(); } set { _fields.SetValue(value); } }
    
        private PropertyValue<HierarchyRole> _hierarchyRole = new PropertyValue<HierarchyRole>(nameof(HADtoDto), nameof(HierarchyRole));
        
        [Required]
        [JsonPropertyName("hierarchyRole")]
        public HierarchyRole HierarchyRole { get { return _hierarchyRole.GetValue(); } set { _hierarchyRole.SetValue(value); } }
    
        private PropertyValue<HADtoDto?> _extends = new PropertyValue<HADtoDto?>(nameof(HADtoDto), nameof(Extends));
        
        [JsonPropertyName("extends")]
        public HADtoDto? Extends { get { return _extends.GetValue(); } set { _extends.SetValue(value); } }
    
        private PropertyValue<List<HADtoDto>> _implements = new PropertyValue<List<HADtoDto>>(nameof(HADtoDto), nameof(Implements));
        
        [Required]
        [JsonPropertyName("implements")]
        public List<HADtoDto> Implements { get { return _implements.GetValue(); } set { _implements.SetValue(value); } }
    
        private PropertyValue<List<HADtoDto>> _inheritors = new PropertyValue<List<HADtoDto>>(nameof(HADtoDto), nameof(Inheritors));
        
        [Required]
        [JsonPropertyName("inheritors")]
        public List<HADtoDto> Inheritors { get { return _inheritors.GetValue(); } set { _inheritors.SetValue(value); } }
    
        private PropertyValue<HADeprecationDto?> _deprecation = new PropertyValue<HADeprecationDto?>(nameof(HADtoDto), nameof(Deprecation));
        
        [JsonPropertyName("deprecation")]
        public HADeprecationDto? Deprecation { get { return _deprecation.GetValue(); } set { _deprecation.SetValue(value); } }
    
        private PropertyValue<bool> _record = new PropertyValue<bool>(nameof(HADtoDto), nameof(Record));
        
        [Required]
        [JsonPropertyName("record")]
        public bool Record { get { return _record.GetValue(); } set { _record.SetValue(value); } }
    
    }
    
}
