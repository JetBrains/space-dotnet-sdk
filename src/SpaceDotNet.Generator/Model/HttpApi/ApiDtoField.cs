using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiDtoField
    {
        [JsonPropertyName("extension")]
        public bool Extension { get; set; }

        [JsonPropertyName("field")]
        public ApiField Field { get; set; } = default!;
    }
}