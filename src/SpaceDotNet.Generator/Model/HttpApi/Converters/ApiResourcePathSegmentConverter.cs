using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceDotNet.Client;

namespace SpaceDotNet.Generator.Model.HttpApi.Converters
{
    public class ApiResourcePathSegmentConverter : JsonConverter<ApiResourcePathSegment>
    {
        public override bool CanConvert(Type objectType) => typeof(ApiResourcePathSegment).IsAssignableFrom(objectType);

        public override ApiResourcePathSegment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;

            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDocument.RootElement;

            var className = jsonObject.GetStringValue("className");
            if (string.Equals(className, "HA_PathSegment.Const", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiResourcePathSegment.Const>(jsonObject.GetRawText());
            } 
            else if (string.Equals(className, "HA_PathSegment.Var", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiResourcePathSegment.Var>(jsonObject.GetRawText());
            }
            else if (string.Equals(className, "HA_PathSegment.PrefixedVar", StringComparison.OrdinalIgnoreCase))
            {
                return JsonSerializer.Deserialize<ApiResourcePathSegment.PrefixedVar>(jsonObject.GetRawText());
            }
            else
            {
                throw new NotSupportedException("Could not deserialize object from JSON: " + jsonObject);
            }
        }

        public override void Write(Utf8JsonWriter writer, ApiResourcePathSegment value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}