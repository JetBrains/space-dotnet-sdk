using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Internal;

namespace JetBrains.Space.Common.Json.Serialization;

/// <summary>
/// A <see cref="JsonConverterFactory"/> that can (de)serialize a Space Date.
/// </summary>
public class SpaceDateConverter : JsonConverterFactory
{
    /// <summary>
    /// Format string used to parse <see cref="DateTime"/> from JSON.
    /// </summary>
    public const string FormatString = "yyyy-MM-dd";

    /// <inheritdoc />
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(DateTime) || typeToConvert == typeof(DateTime?);

    /// <inheritdoc />
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(DateTime?))
        {
            return new NullableDateTimeConverter(FormatString);
        }

        if (typeToConvert == typeof(DateTime))
        {
            return new NonNullableDateTimeConverter(new NullableDateTimeConverter(FormatString));
        }

        throw new JsonException();
    }
}