using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiResource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
        
        [JsonPropertyName("path")]
        public ApiResourcePath Path { get; set; } = default!;
        
        [JsonPropertyName("displaySingular")]
        public string DisplaySingular { get; set; } = default!;
        
        [JsonPropertyName("displayPlural")]
        public string DisplayPlural { get; set; } = default!;
        
        [JsonPropertyName("nestedResources")]
        public List<ApiResource> NestedResources { get; set; } = new List<ApiResource>();
        
        [JsonPropertyName("endpoints")]
        public List<ApiEndpoint> Endpoints { get; set; } = new List<ApiEndpoint>();
    }
}