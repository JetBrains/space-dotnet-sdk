using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Common.Json.Serialization
{
    public class ClassNameInterfaceDtoTypeConverter : ClassNameDtoTypeConverter
    {
        public override bool CanConvert(Type objectType) 
            => objectType.IsInterface && objectType.Namespace == SpaceDotNetClientNamespace && objectType.FullName != null && objectType.FullName.EndsWith("Dto");
    }
    
    public class ClassNameDtoTypeConverter : JsonConverter<IClassNameConvertible>
    {
        protected readonly string SpaceDotNetClientNamespace = "SpaceDotNet.Client";
        
        private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
        
        public override bool CanConvert(Type objectType) 
            => typeof(IClassNameConvertible).IsAssignableFrom(objectType);
    
        [CanBeNull]
        public override IClassNameConvertible Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
                    targetType = Type.GetType(SpaceDotNetClientNamespace + "." + className + "Dto, " + SpaceDotNetClientNamespace);
                    if (targetType != null)
                    {
                        TypeMap[className] = targetType;
                    }
                }
                if (targetType != null && typeof(IClassNameConvertible).IsAssignableFrom(targetType))
                {
                    return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as IClassNameConvertible;
                }
            }

            return null;
        }
    
        public override void Write(Utf8JsonWriter writer, IClassNameConvertible value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}