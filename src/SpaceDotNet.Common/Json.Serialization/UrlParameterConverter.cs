using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Common.Json.Serialization
{
    public class UrlParameterConverter : JsonConverter<object>
    {
        private static readonly Type UrlParameterType = typeof(IUrlParameter);
        
        public override bool CanConvert(Type objectType) => objectType != UrlParameterType && UrlParameterType.IsAssignableFrom(objectType);
        
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return document.RootElement.Clone();
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}