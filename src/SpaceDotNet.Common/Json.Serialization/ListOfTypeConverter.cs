using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable disable

namespace SpaceDotNet.Common.Json.Serialization
{
    // Concept: https://www.mrlacey.com/2019/10/deserializing-generic-interfaces-with.html
    public abstract class ListOfTypeConverter<TElement> : JsonConverter<object>
    {
        private readonly JsonConverter<TElement> _elementConverter;

        protected ListOfTypeConverter(JsonConverter<TElement> elementConverter)
        {
            _elementConverter = elementConverter;
        }
        
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