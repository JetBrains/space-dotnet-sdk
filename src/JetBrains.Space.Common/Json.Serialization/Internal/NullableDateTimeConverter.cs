using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JetBrains.Space.Common.Json.Serialization.Internal
{
    internal class NullableDateTimeConverter : JsonConverter<DateTime?>
    {
        private readonly string _expectedDateTimeFormat;

        public NullableDateTimeConverter(string expectedDateTimeFormat)
        {
            _expectedDateTimeFormat = expectedDateTimeFormat;
        }
        
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            DateTime returnValue = default;
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();
                    if (propertyName.Equals("iso", StringComparison.OrdinalIgnoreCase))
                    {
                        reader.Read();
                        var iso = reader.GetString();

                        if (!string.IsNullOrEmpty(iso) && DateTime.TryParseExact(
                            iso, _expectedDateTimeFormat, CultureInfo.InvariantCulture.DateTimeFormat,
                            DateTimeStyles.AdjustToUniversal, out var dateTime))
                        {
                            returnValue = dateTime;
                        }
                    }
                }
            
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return returnValue;
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString(
                    _expectedDateTimeFormat, CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}