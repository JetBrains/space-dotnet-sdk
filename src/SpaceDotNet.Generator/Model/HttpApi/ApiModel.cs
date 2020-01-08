using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiModel
    {
        [JsonPropertyName("dto")]
        public List<ApiDto> Dto { get; set; } = new List<ApiDto>();
        
        [JsonPropertyName("enums")]
        public List<ApiEnum> Enums { get; set; } = new List<ApiEnum>();
        
        [JsonPropertyName("resources")]
        public List<ApiResource> Resources { get; set; } = new List<ApiResource>();
    }
}