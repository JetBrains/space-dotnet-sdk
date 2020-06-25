using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Json.Serialization;

#nullable disable

namespace SpaceDotNet.Generator.Model.HttpApi.Converters
{
    public class ApiFieldTypeConverter : JsonConverter<ApiFieldType>
    {
        private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            { "HA_Type.Array", typeof(ApiFieldType.Array) },
            { "HA_Type.Dto", typeof(ApiFieldType.Dto) },
            { "HA_Type.Enum", typeof(ApiFieldType.Enum) },
            { "HA_Type.UrlParam", typeof(ApiFieldType.UrlParam) },
            { "HA_Type.Object", typeof(ApiFieldType.Object) },
            { "HA_Type.Primitive", typeof(ApiFieldType.Primitive) },
            { "HA_Type.Ref", typeof(ApiFieldType.Ref) }
        };
        
        public override bool CanConvert(Type objectType) => typeof(ApiFieldType).IsAssignableFrom(objectType);

        [CanBeNull]
        public override ApiFieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;

            var readerAtStart = reader;
            
            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDocument.RootElement;

            var className = jsonObject.GetStringValue("className");
            if (!string.IsNullOrEmpty(className) && TypeMap.TryGetValue(className, out var targetType))
            {
                return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as ApiFieldType;
            }
            
            return JsonSerializer.Deserialize<ApiFieldType.Object>(ref readerAtStart);
        }

        public override void Write(Utf8JsonWriter writer, ApiFieldType value, JsonSerializerOptions options)
        {
            value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}