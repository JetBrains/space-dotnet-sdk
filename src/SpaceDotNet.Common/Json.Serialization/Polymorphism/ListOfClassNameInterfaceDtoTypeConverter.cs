using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Types;

#nullable disable

namespace SpaceDotNet.Common.Json.Serialization.Polymorphism
{
    // Concept: https://www.mrlacey.com/2019/10/deserializing-generic-interfaces-with.html
    public class ListOfClassNameInterfaceDtoTypeConverter : JsonConverter<object>
    {
        private readonly ClassNameInterfaceDtoTypeConverter _elementReader = new ClassNameInterfaceDtoTypeConverter();
        
        public override bool CanConvert(Type objectType)
        {
            if (objectType.IsGenericType && objectType.Name.Equals(typeof(List<>).Name))
            {
                var genericArgument = objectType.GetGenericArguments().FirstOrDefault();
                if (genericArgument != null)
                {
                    return _elementReader.CanConvert(genericArgument);
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
                var element = _elementReader.Read(ref reader, typeof(IClassNameConvertible), options);
                collection.Add(element);
            }

            return collection;
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}