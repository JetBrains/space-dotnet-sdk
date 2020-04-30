using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Common.Json.Serialization
{
    public class ClassNameInterfaceDtoTypeConverter : JsonConverter<IClassNameConvertible>
    {
        private const string SpaceDotNetClientNamespace = "SpaceDotNet.Client";
        
        private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
        
        public override bool CanConvert(Type objectType) => objectType.IsInterface && objectType.Namespace == SpaceDotNetClientNamespace && objectType.FullName != null && objectType.FullName.EndsWith("Dto");
    
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
            
            return JsonSerializer.Deserialize<IClassNameConvertible>(ref readerAtStart);
        }
    
        public override void Write(Utf8JsonWriter writer, IClassNameConvertible value, JsonSerializerOptions options)
        {
            // TODO type checks
            // if (string.IsNullOrEmpty(value.ClassName))
            // {
            //     value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
            // }
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
    
    public class ClassNameDtoTypeConverter : JsonConverter<IClassNameConvertible>
    {
        private const string SpaceDotNetClientNamespace = "SpaceDotNet.Client";
        
        private static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
        
        public override bool CanConvert(Type objectType) => typeof(IClassNameConvertible).IsAssignableFrom(objectType);
    
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
            // TODO type checks
            // if (string.IsNullOrEmpty(value.ClassName))
            // {
            //     value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
            // }
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}