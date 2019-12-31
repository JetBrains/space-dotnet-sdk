using System.Collections.Generic;
using Newtonsoft.Json;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("path")]
        public ApiResourcePath Path { get; set; }
        
        [JsonProperty("displaySingular")]
        public string DisplaySingular { get; set; }
        
        [JsonProperty("displayPlural")]
        public string DisplayPlural { get; set; }
        
        [JsonProperty("nestedResources")]
        public List<ApiResource> NestedResources { get; set; } = new List<ApiResource>();
        
        [JsonProperty("endpoints")]
        public List<ApiEndpoint> Endpoints { get; set; } = new List<ApiEndpoint>();
    }
}