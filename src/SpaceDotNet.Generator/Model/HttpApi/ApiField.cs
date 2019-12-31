using Newtonsoft.Json;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiField
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("type")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType Type { get; set; }
    }
}