using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpaceDotNet.Generator.Model.HttpApi.Converters
{
    public class ApiResourcePathSegmentConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(ApiResourcePathSegment).IsAssignableFrom(objectType);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            
            var jsonObject = JObject.Load(reader);

            var className = jsonObject.Value<string>("className");
            if (string.Equals(className, "HA_PathSegment.Const", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiResourcePathSegment.Const();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            } 
            else if (string.Equals(className, "HA_PathSegment.Var", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiResourcePathSegment.Var();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
            else if (string.Equals(className, "HA_PathSegment.PrefixedVar", StringComparison.OrdinalIgnoreCase))
            {
                var item = new ApiResourcePathSegment.PrefixedVar();
                serializer.Populate(jsonObject.CreateReader(), item);
                return item;
            }
            else
            {
                throw new NotSupportedException("Could not deserialize object from JSON: " + jsonObject.ToString());
            }
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}