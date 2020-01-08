using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiResource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("path")]
        public ApiResourcePath Path { get; set; }
        
        [JsonPropertyName("displaySingular")]
        public string DisplaySingular { get; set; }
        
        [JsonPropertyName("displayPlural")]
        public string DisplayPlural { get; set; }
        
        [JsonPropertyName("nestedResources")]
        public List<ApiResource> NestedResources { get; set; } = new List<ApiResource>();
        
        [JsonPropertyName("endpoints")]
        public List<ApiEndpoint> Endpoints { get; set; } = new List<ApiEndpoint>();
    }
}