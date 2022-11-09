using System.Text.Json;
using JetBrains.Space.Common.Json.Serialization;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class SpaceDateConverterTests
{
    private static JsonSerializerOptions CreateSerializerOptions()
    {
        var options = new JsonSerializerOptions
        {
            MaxDepth = 32,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        options.Converters.Add(new SpaceDateConverter());
            
        return options;
    }

    [Fact]
    public void CanDeserializeDateTime()
    {
        var inputJsonString = "{\"iso\":\"2020-10-21\",\"timestamp\":1603297800000}";

        var result = (DateTime)(JsonSerializer.Deserialize(inputJsonString, typeof(DateTime), CreateSerializerOptions())  ?? throw new NullReferenceException("Deserialized value is null."));

        Assert.Equal("2020-10-21", result.ToString("yyyy-MM-dd"));
    }

    [Fact]
    public void CanDeserializeNullableDateTime()
    {
        var inputJsonString = "{\"iso\":\"2020-10-21\",\"timestamp\":1603297800000}";

        var result = (DateTime?)JsonSerializer.Deserialize(inputJsonString, typeof(DateTime?), CreateSerializerOptions());

        Assert.NotNull(result);
        if (result != null)
        {
            Assert.Equal("2020-10-21", result.Value.ToString("yyyy-MM-dd"));
        }
    }
}