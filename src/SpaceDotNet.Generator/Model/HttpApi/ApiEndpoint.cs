using System.Collections.Generic;
using Newtonsoft.Json;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiEndpoint
    {
        [JsonProperty("resource")]
        public ApiResource Resource { get; set; }
        
        [JsonProperty("method")]
        public ApiMethod Method { get; set; }
        
        [JsonProperty("parameters")]
        public List<ApiParameter> Parameters { get; set; } = new List<ApiParameter>();
        
        [JsonProperty("requestBody")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType.Object? RequestBody { get; set; }
        
        [JsonProperty("responseBody")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType? ResponseBody { get; set; }
        
        [JsonProperty("path")]
        public ApiResourcePath Path { get; set; }
        
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        
        [JsonProperty("doc")]
        public string? Documentation { get; set; }
    }
}