using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Common.Json.Serialization
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that can (de)serialize an instance of <see cref="IUrlParameter"/>.
    /// </summary>
    public class UrlParameterConverter : JsonConverter<object>
    {
        private static readonly Type UrlParameterType = typeof(IUrlParameter);
        
        /// <inheritdoc />
        public override bool CanConvert(Type objectType) => objectType != UrlParameterType && UrlParameterType.IsAssignableFrom(objectType);
        
        /// <inheritdoc />
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return document.RootElement.Clone();
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}