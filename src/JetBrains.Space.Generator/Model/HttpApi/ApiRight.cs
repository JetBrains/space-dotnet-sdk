using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    public class ApiRight
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = default!;
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}