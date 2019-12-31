using System;
using Newtonsoft.Json;

namespace SpaceDotNet.Client
{
    public class EnumerationConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(Enumeration).IsAssignableFrom(objectType);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                return Enumeration.FromValue(objectType, reader.Value.ToString());
            }

            return null;
        }

        public override bool CanWrite => true;

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, (value as Enumeration)?.Value);
        }
    }
}