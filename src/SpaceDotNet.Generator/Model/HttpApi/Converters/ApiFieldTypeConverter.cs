using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceDotNet.Client;

namespace SpaceDotNet.Generator.Model.HttpApi.Converters
{
    public class ApiFieldTypeConverter : JsonConverter<ApiFieldType>
    {
        public override bool CanConvert(Type objectType) => typeof(ApiFieldType).IsAssignableFrom(objectType);

        public override ApiFieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;

            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDocument.RootElement;

            var className = jsonObject.GetStringValue("className");
            if (string.Equals(className, "HA_Type.Array", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiFieldType.Array>(jsonObject.GetRawText());
            } 
            else if (string.Equals(className, "HA_Type.Dto", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiFieldType.Dto>(jsonObject.GetRawText());
            }
            else if (string.Equals(className, "HA_Type.Enum", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiFieldType.Enum>(jsonObject.GetRawText());
            }
            else if (string.Equals(className, "HA_Type.Object", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiFieldType.Object>(jsonObject.GetRawText());
            }
            else if (string.Equals(className, "HA_Type.Primitive", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiFieldType.Primitive>(jsonObject.GetRawText());
            }
            else if (string.Equals(className, "HA_Type.Ref", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiFieldType.Ref>(jsonObject.GetRawText());
            }
            else
            {
                // Default to object
                return JsonSerializer.Deserialize<ApiFieldType.Object>(jsonObject.GetRawText());
            }
        }

        public override void Write(Utf8JsonWriter writer, ApiFieldType value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}