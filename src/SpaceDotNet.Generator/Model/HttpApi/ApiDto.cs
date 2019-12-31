using System.Collections.Generic;
using Newtonsoft.Json;
using SpaceDotNet.Client;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("fields")]
        public List<ApiDtoField> Fields { get; set; } = new List<ApiDtoField>();
        
        [JsonProperty("extends")]
        public Reference<ApiDto>? Extends { get; set; }
        
        [JsonProperty("implements")]
        public List<Reference<ApiDto>> Implements { get; set; } = new List<Reference<ApiDto>>();
    }
}