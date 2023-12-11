using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiRawRequestPayload : IApiRequestPayload
{
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }

    [JsonPropertyName("allowedMimeTypes")]
    public List<string> AllowedMimeTypes { get; set; } = new(0);
}