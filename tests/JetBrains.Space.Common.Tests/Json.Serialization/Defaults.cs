using System.Text.Json;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public static class Defaults
{
    public static JsonSerializerOptions CreateSerializerOptions() =>
        new JsonSerializerOptions
        {
            MaxDepth = 32,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }.AddSpaceJsonTypeConverters();
}