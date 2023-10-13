using System.Text.Json;
using JetBrains.Space.Common.Json.Serialization;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class SpaceDurationConverterTests
{
    private static JsonSerializerOptions CreateSerializerOptions()
    {
        var options = Defaults.CreateSerializerOptions();

        options.Converters.Add(new SpaceDurationConverter());
            
        return options;
    }

    [Fact]
    public void CanDeserializeDateTime()
    {
        var inputJsonString = "\"PT1H30M\"";

        var result = (TimeSpan)(JsonSerializer.Deserialize(inputJsonString, typeof(TimeSpan), CreateSerializerOptions()) ?? throw new NullReferenceException("Deserialized value is null."));

        Assert.Equal(1, result.Hours);
        Assert.Equal(30, result.Minutes);
    }

    [Fact]
    public void CanDeserializeNullableDateTime()
    {
        var inputJsonString = "\"PT1H30M\"";

        var result = (TimeSpan?)JsonSerializer.Deserialize(inputJsonString, typeof(TimeSpan?), CreateSerializerOptions());

        Assert.NotNull(result);
        if (result != null)
        {
            Assert.Equal(1, result.Value.Hours);
            Assert.Equal(30, result.Value.Minutes);
        }
    }
}