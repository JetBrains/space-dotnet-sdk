using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    public class ApiEndpoint
    {
        [JsonPropertyName("resource")]
        public ApiResource Resource { get; set; } = default!;
        
        [JsonPropertyName("deprecation")]
        public ApiDeprecation? Deprecation { get; set; } = default;
        
        [JsonPropertyName("method")]
        public ApiMethod Method { get; set; } = default!;
        
        [JsonPropertyName("parameters")]
        public List<ApiParameter> Parameters { get; set; } = new List<ApiParameter>();
        
        [JsonPropertyName("requestBody")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType.Object? RequestBody { get; set; }
        
        [JsonPropertyName("responseBody")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType? ResponseBody { get; set; }
        
        [JsonPropertyName("path")]
        public ApiResourcePath Path { get; set; } = default!;
        
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; } = default!;
        
        [JsonPropertyName("doc")]
        public string? Documentation { get; set; }
        
        [JsonPropertyName("functionName")]
        public string? FunctionName { get; set; }
        
        [JsonPropertyName("rights")]
        // ReSharper disable once CollectionNeverUpdated.Global
        public List<ApiRight>? Rights { get; set; }
    }
}