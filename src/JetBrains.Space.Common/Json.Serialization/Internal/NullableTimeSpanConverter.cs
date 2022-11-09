using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace JetBrains.Space.Common.Json.Serialization.Internal;

internal class NullableTimeSpanConverter : JsonConverter<TimeSpan?>
{
    public override TimeSpan? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }
            
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }
        
        var isoString = reader.GetString();
        if (isoString != null)
        {
            return XmlConvert.ToTimeSpan(isoString);
        }
        return null;
    }

    public override void Write(Utf8JsonWriter writer, TimeSpan? value, JsonSerializerOptions options)
    {
        if (value.HasValue)
        {
            writer.WriteStringValue(XmlConvert.ToString(value.Value));
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}