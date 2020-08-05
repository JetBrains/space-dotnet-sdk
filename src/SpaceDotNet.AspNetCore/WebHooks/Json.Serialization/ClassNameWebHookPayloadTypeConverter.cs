using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.AspNetCore.WebHooks.Types;
using SpaceDotNet.Common.Json.Serialization;

#nullable disable

namespace SpaceDotNet.AspNetCore.WebHooks.Json.Serialization
{
    public class ClassNameWebHookPayloadTypeConverter : JsonConverter<IWebHookPayload>
    {
        protected readonly string SpaceDotNetWebHooksNamespace = "SpaceDotNet.AspNetCore.WebHooks.Types";
        protected readonly string SpaceDotNetWebHooksAssemblyName = "SpaceDotNet.AspNetCore";
        
        private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
        
        public override bool CanConvert(Type objectType) 
            => typeof(IWebHookPayload).IsAssignableFrom(objectType);
    
        [CanBeNull]
        public override IWebHookPayload Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;
    
            var readerAtStart = reader;
            
            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDocument.RootElement;
    
            var className = jsonObject.GetStringValue("className");
            if (!string.IsNullOrEmpty(className))
            {
                if (!TypeMap.TryGetValue(className, out var targetType))
                {
                    targetType = Type.GetType(SpaceDotNetWebHooksNamespace + "." + className + ", " + SpaceDotNetWebHooksAssemblyName);
                    if (targetType != null)
                    {
                        TypeMap[className] = targetType;
                    }
                }
                if (targetType != null && typeof(IWebHookPayload).IsAssignableFrom(targetType))
                {
                    return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as IWebHookPayload;
                }
            }

            return null;
        }
    
        public override void Write(Utf8JsonWriter writer, IWebHookPayload value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}