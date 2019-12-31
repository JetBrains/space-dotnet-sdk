using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpaceDotNet.Generator.Model.HttpApi.Converters
{
    public class ApiFieldTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(ApiFieldType).IsAssignableFrom(objectType);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            
            var jsonObject = JObject.Load(reader);

            var className = jsonObject.Value<string>("className");
            if (string.Equals(className, "HA_Type.Array", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiFieldType.Array();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            } 
            else if (string.Equals(className, "HA_Type.Dto", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiFieldType.Dto();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
            else if (string.Equals(className, "HA_Type.Enum", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiFieldType.Enum();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
            else if (string.Equals(className, "HA_Type.Object", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiFieldType.Object();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
            else if (string.Equals(className, "HA_Type.Primitive", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiFieldType.Primitive();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
            else if (string.Equals(className, "HA_Type.Ref", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiFieldType.Ref();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
            else
            {
                // Default to object
                var item = new ApiFieldType.Object();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}