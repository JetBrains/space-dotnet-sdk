using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiDtoField
    {
        [JsonPropertyName("field")]
        public ApiField Field { get; set; }
    }
}