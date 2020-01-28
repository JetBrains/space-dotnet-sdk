using System.Collections.Generic;
using System.Text.Json.Serialization;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiEndpoint
    {
        [JsonPropertyName("resource")]
        public ApiResource Resource { get; set; }
        
        [JsonPropertyName("deprecation")]
        public ApiDeprecation? Deprecation { get; set; }
        
        [JsonPropertyName("method")]
        public ApiMethod Method { get; set; }
        
        [JsonPropertyName("parameters")]
        public List<ApiParameter> Parameters { get; set; } = new List<ApiParameter>();
        
        [JsonPropertyName("requestBody")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType.Object? RequestBody { get; set; }
        
        [JsonPropertyName("responseBody")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType? ResponseBody { get; set; }
        
        [JsonPropertyName("path")]
        public ApiResourcePath Path { get; set; }
        
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        [JsonPropertyName("doc")]
        public string? Documentation { get; set; }
    }
}