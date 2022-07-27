#nullable disable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Internal;

namespace JetBrains.Space.Common.Json.Serialization;

/// <summary>
/// A <see cref="JsonConverterFactory"/> that can (de)serialize a Space Duration.
/// </summary>
public class SpaceDurationConverter : JsonConverterFactory
{
    /// <inheritdoc />
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(TimeSpan) || typeToConvert == typeof(TimeSpan?);

    /// <inheritdoc />
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(TimeSpan?))
        {
            return new NullableTimeSpanConverter();
        }

        if (typeToConvert == typeof(TimeSpan))
        {
            return new NonNullableTimeSpanConverter(new NullableTimeSpanConverter());
        }

        throw new JsonException();
    }
}