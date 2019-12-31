using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiModel
    {
        [JsonProperty("dto")]
        public List<ApiDto> Dto { get; set; } = new List<ApiDto>();
        
        [JsonProperty("enums")]
        public List<ApiEnum> Enums { get; set; } = new List<ApiEnum>();
        
        [JsonProperty("resources")]
        public List<ApiResource> Resources { get; set; } = new List<ApiResource>();
    }
}