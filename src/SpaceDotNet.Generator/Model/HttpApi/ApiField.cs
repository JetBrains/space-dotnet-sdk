using System.Text.Json.Serialization;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiField
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
        
        [JsonPropertyName("type")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiFieldType Type { get; set; } = default!;
        
        [JsonPropertyName("optional")]
        public bool Optional { get; set; }
        
        [JsonPropertyName("defaultValue")]
        public ApiDefaultValue? DefaultValue { get; set; }
    }
}