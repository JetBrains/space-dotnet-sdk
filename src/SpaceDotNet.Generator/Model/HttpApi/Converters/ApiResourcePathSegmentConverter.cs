using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi.Converters
{
    public class ApiResourcePathSegmentConverter : JsonConverter<ApiResourcePathSegment>
    {
        private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            { "HA_PathSegment.Const", typeof(ApiResourcePathSegment.Const) },
            { "HA_PathSegment.Var", typeof(ApiResourcePathSegment.Var) },
            { "HA_PathSegment.PrefixedVar", typeof(ApiResourcePathSegment.PrefixedVar) }
        };
        
        public override bool CanConvert(Type objectType) => typeof(ApiResourcePathSegment).IsAssignableFrom(objectType);

        public override ApiResourcePathSegment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;

            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDocument.RootElement;

            var className = jsonObject.GetStringValue("className");
            if (!string.IsNullOrEmpty(className) && TypeMap.TryGetValue(className, out var targetType))
            {
                return JsonSerializer.Deserialize(jsonObject.GetRawText(), targetType, options) as ApiResourcePathSegment;
            }
            
            throw new NotSupportedException("Could not deserialize object from JSON: " + jsonObject);
        }

        public override void Write(Utf8JsonWriter writer, ApiResourcePathSegment value, JsonSerializerOptions options)
        {
            if (string.IsNullOrEmpty(value.ClassName))
            {
                value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
            }
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}