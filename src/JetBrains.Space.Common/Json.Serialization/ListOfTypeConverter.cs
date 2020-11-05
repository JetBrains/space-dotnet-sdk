using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable disable

namespace JetBrains.Space.Common.Json.Serialization
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that can (de)serialize a collection of <typeparamref name="TElement"/>.
    /// </summary>
    /// <typeparam name="TElement">The type of the element in the (de)serialized collection.</typeparam>
    /// <remarks>
    /// Concept: https://www.mrlacey.com/2019/10/deserializing-generic-interfaces-with.html
    /// </remarks>
    public abstract class ListOfTypeConverter<TElement> : JsonConverter<object>
    {
        private readonly JsonConverter<TElement> _elementConverter;

        /// <summary>
        /// Creates a new <see cref="ListOfTypeConverter{TElement}"/> instance.
        /// </summary>
        /// <param name="elementConverter">A <see cref="JsonConverter{T}"/> instance that can convert a <typeparamref name="TElement"/> instance.</param>
        protected ListOfTypeConverter(JsonConverter<TElement> elementConverter)
        {
            _elementConverter = elementConverter;
        }
        
        /// <inheritdoc />
        public override bool CanConvert(Type objectType)
        {
            if (objectType.IsGenericType && objectType.Name.Equals(typeof(List<>).Name))
            {
                var genericArgument = objectType.GetGenericArguments().FirstOrDefault();
                if (genericArgument != null)
                {
                    return _elementConverter.CanConvert(genericArgument);
                }
            }

            return false;
        }
        
        /// <inheritdoc />
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;

            var collection = Activator.CreateInstance(typeToConvert) as IList;
            if (collection == null) return null;

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected start of array.");
            }
            
            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                var element = _elementConverter.Read(ref reader, typeof(TElement), options);
                collection.Add(element);
            }

            return collection;
        }
        
        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
            
            var enumerable = value as IEnumerable<TElement>;
            if (enumerable == null) return;
            
            writer.WriteStartArray();
            
            foreach (var item in enumerable)
            {
                _elementConverter.Write(writer, item, options);
            }
            
            writer.WriteEndArray();
        }
    }
}