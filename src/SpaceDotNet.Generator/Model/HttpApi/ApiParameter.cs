using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiParameter
    {
        [JsonPropertyName("field")]
        public ApiField Field { get; set; }
        
        [JsonPropertyName("path")]
        public bool Path { get; set; }
    }
}