using System.Collections.Generic;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
        
        [JsonPropertyName("deprecation")]
        public ApiDeprecation? Deprecation { get; set; } = default;
        
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
        
        [JsonPropertyName("fields")]
        public List<ApiDtoField> Fields { get; set; } = new List<ApiDtoField>();
        
        [JsonPropertyName("extends")]
        public Reference<ApiDto>? Extends { get; set; }
        
        [JsonPropertyName("implements")]
        public List<Reference<ApiDto>> Implements { get; set; } = new List<Reference<ApiDto>>();
        
        [JsonPropertyName("inheritors")]
        public List<Reference<ApiDto>> Inheritors { get; set; } = new List<Reference<ApiDto>>();
        
        [JsonPropertyName("hierarchyRole")]
        public HierarchyRole HierarchyRole { get; set; } = default!;

        [JsonPropertyName("record")]
        public bool Record { get; set; }
    }
}