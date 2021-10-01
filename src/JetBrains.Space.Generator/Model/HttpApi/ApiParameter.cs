using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiParameter
{
    [JsonPropertyName("field")]
    public ApiField Field { get; set; } = null!;

    [JsonPropertyName("path")]
    public bool Path { get; set; }
}