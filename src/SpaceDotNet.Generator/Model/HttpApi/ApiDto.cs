using System.Collections.Generic;
using System.Text.Json.Serialization;
using SpaceDotNet.Client;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("fields")]
        public List<ApiDtoField> Fields { get; set; } = new List<ApiDtoField>();
        
        [JsonPropertyName("extends")]
        public Reference<ApiDto>? Extends { get; set; }
        
        [JsonPropertyName("implements")]
        public List<Reference<ApiDto>> Implements { get; set; } = new List<Reference<ApiDto>>();
    }
}