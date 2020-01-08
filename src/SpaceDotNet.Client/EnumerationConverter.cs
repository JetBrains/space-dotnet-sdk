using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Client
{
    public class EnumerationConverter : JsonConverter<Enumeration>
    {
        public override bool CanConvert(Type objectType) => typeof(Enumeration).IsAssignableFrom(objectType);

        public override Enumeration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                return Enumeration.FromValue(typeToConvert, reader.GetString());
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, Enumeration value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value?.Value);
        }
    }
}