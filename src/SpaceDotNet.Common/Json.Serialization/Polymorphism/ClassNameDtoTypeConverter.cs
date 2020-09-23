using System;
using System.Collections.Concurrent;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Json.Serialization.Internal;
using SpaceDotNet.Common.Types;

#nullable disable

namespace SpaceDotNet.Common.Json.Serialization.Polymorphism
{
    public class ClassNameDtoTypeConverter : JsonConverter<IClassNameConvertible>
    {
        protected readonly string SpaceDotNetClientNamespace = "SpaceDotNet.Client";
        protected readonly string SpaceDotNetClientAssemblyName = "SpaceDotNet.Client";
        
        private static readonly ConcurrentDictionary<string, Type> TypeMap = new ConcurrentDictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
        
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
                    targetType = Type.GetType(SpaceDotNetClientNamespace + "." + CSharpIdentifier.ForClassOrNamespace(className) + ", " + SpaceDotNetClientAssemblyName);
                    if (targetType != null)
                    {
                        TypeMap[className] = targetType;
                    }
                }
                if (targetType != null && typeof(IClassNameConvertible).IsAssignableFrom(targetType))
                {
                    var value = JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as IClassNameConvertible;
                    
                    PropagatePropertyAccessPathHelper.SetAccessPathForValue(targetType.Name, true, value);

                    return value;
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