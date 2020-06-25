using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi.Converters
{
    public class ApiUrlParameterOptionConverter : JsonConverter<ApiUrlParameterOption>
    {
        private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            { "HA_UrlParameterOption.Var", typeof(ApiUrlParameterOption.Var) },
            { "HA_UrlParameterOption.Const", typeof(ApiUrlParameterOption.Const) }
        };
        
        public override bool CanConvert(Type objectType) => typeof(ApiUrlParameterOption).IsAssignableFrom(objectType);

        [CanBeNull]
        public override ApiUrlParameterOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;

            var readerAtStart = reader;
            
            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDocument.RootElement;

            var className = jsonObject.GetStringValue("className");
            if (!string.IsNullOrEmpty(className) && TypeMap.TryGetValue(className, out var targetType))
            {
                return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as ApiUrlParameterOption;
            }
            
            throw new JsonException("No className field was found that maps to a ApiUrlParameterOption subtype.");
        }

        public override void Write(Utf8JsonWriter writer, ApiUrlParameterOption value, JsonSerializerOptions options)
        {
            value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}