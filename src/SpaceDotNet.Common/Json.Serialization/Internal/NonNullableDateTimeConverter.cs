using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Common.Json.Serialization.Internal
{
    internal class NonNullableDateTimeConverter : JsonConverter<DateTime>
    {
        private readonly NullableDateTimeConverter _inner;

        public NonNullableDateTimeConverter(NullableDateTimeConverter inner)
        {
            _inner = inner;
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            _inner.Read(ref reader, typeof(DateTime?), options).GetValueOrDefault();

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) =>
            _inner.Write(writer, value, options);
    }
}