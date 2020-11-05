using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    public class ApiModel
    {
        [JsonPropertyName("dto")]
        public List<ApiDto> Dto { get; set; } = new List<ApiDto>();
        
        [JsonPropertyName("enums")]
        public List<ApiEnum> Enums { get; set; } = new List<ApiEnum>();
        
        [JsonPropertyName("urlParams")]
        public List<ApiUrlParameter> UrlParameters { get; set; } = new List<ApiUrlParameter>();
        
        [JsonPropertyName("resources")]
        public List<ApiResource> Resources { get; set; } = new List<ApiResource>();
        
        [JsonPropertyName("menuIds")]
        public List<ApiMenuId> MenuIds { get; set; } = new List<ApiMenuId>();
    }
}