using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiDtoField
{
    [JsonPropertyName("extension")]
    public bool Extension { get; set; }

    [JsonPropertyName("field")]
    public ApiField Field { get; set; } = default!;
}