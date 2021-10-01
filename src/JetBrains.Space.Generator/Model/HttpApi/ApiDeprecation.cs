using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiDeprecation
{
    [JsonPropertyName("forRemoval")]
    public bool ForRemoval { get; set; }
        
    [JsonPropertyName("message")]
    public string? Message { get; set; }
        
    [JsonPropertyName("since")]
    public string? Since { get; set; }
}