using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiDescription
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = default!;
    
    [JsonPropertyName("helpTopic")]
    public string? HelpTopic { get; set; }
}