using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JetBrains.Space.Common.Json.Serialization.Internal;

internal class NonNullableTimeSpanConverter : JsonConverter<TimeSpan>
{
    private readonly NullableTimeSpanConverter _inner;

    public NonNullableTimeSpanConverter(NullableTimeSpanConverter inner)
    {
        _inner = inner;
    }

    public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        _inner.Read(ref reader, typeof(DateTime?), options).GetValueOrDefault();

    public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options) =>
        _inner.Write(writer, value, options);
}