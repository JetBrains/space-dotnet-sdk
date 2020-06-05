using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiUrlParameter
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
        
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
        
        [JsonPropertyName("options")]
        public List<ApiUrlParameterOption> Options { get; set; } = new List<ApiUrlParameterOption>();
        
        [JsonPropertyName("deprecation")]
        public ApiDeprecation? Deprecation { get; set; } = default;
    }
}