using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Types;

#nullable disable

namespace SpaceDotNet.Common.Json.Serialization
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that can (de)serialize a collection of <see cref="Enumeration"/>.
    /// </summary>
    public class ListOfEnumerationConverter : ListOfTypeConverter<Enumeration>
    {
        /// <summary>
        /// Creates a new <see cref="ListOfEnumerationConverter"/> instance.
        /// </summary>
        public ListOfEnumerationConverter() : base(new EnumerationConverter())
        {
        }
    }
    
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that can (de)serialize an instance of <see cref="Enumeration"/>.
    /// </summary>
    public class EnumerationConverter : JsonConverter<Enumeration>
    {
        private static readonly Type EnumerationType = typeof(Enumeration);
        
        /// <inheritdoc />
        public override bool CanConvert(Type objectType) => objectType != EnumerationType && EnumerationType.IsAssignableFrom(objectType);
      
        /// <inheritdoc />
        public override Enumeration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType == JsonTokenType.String 
                ? Enumeration.FromValue(typeToConvert, reader.GetString())
                : null;
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Enumeration value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value?.Value);
        }
    }
}