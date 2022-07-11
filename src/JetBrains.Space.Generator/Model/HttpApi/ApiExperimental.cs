using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiExperimental
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}