using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization.Internal;
using JetBrains.Space.Common.Types;

#nullable disable

namespace JetBrains.Space.Common.Json.Serialization.Polymorphism;

/// <summary>
/// A <see cref="JsonConverterFactory"/> that can (de)serialize an instance of <see cref="IClassNameConvertible"/>.
/// </summary>
public class ClassNameDtoTypeConverter : JsonConverterFactory
{
    private static readonly Type GenericConverterType = typeof(ClassNameDtoTypeConverter<>);
        
    /// <inheritdoc />
    public override bool CanConvert(Type objectType) 
        => typeof(IClassNameConvertible).IsAssignableFrom(objectType);

    /// <inheritdoc />
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var constructedType = GenericConverterType.MakeGenericType(typeToConvert);
        return Activator.CreateInstance(constructedType) as JsonConverter;
    }
}
    
/// <summary>
/// A <see cref="JsonConverter{T}"/> that can (de)serialize an instance of <see cref="IClassNameConvertible"/>.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> to convert.</typeparam>
public class ClassNameDtoTypeConverter<T> : JsonConverter<T>
    where T : class, IClassNameConvertible
{
    /// <inheritdoc />
    public override bool CanConvert(Type objectType) 
        => typeof(IClassNameConvertible).IsAssignableFrom(objectType);
    
    /// <inheritdoc />
    [CanBeNull]
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;
    
        var readerAtStart = reader;
            
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var jsonObject = jsonDocument.RootElement;
    
        var className = jsonObject.GetStringValue("className");
        if (!string.IsNullOrEmpty(className))
        {
            if (ClassNameTypeUtility.TryResolve(
                    className: className, 
                    spaceDotNetCSharpTypeName: ClassNameTypeUtility.SpaceDotNetClientNamespace + "." + CSharpIdentifier.ForClassOrNamespace(className) + ", " + ClassNameTypeUtility.SpaceDotNetClientAssemblyName,
                    targetType: out var targetType)
                && typeof(IClassNameConvertible).IsAssignableFrom(targetType))
            {
                var value = JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as T;
                    
                PropagatePropertyAccessPathHelper.SetAccessPathForValue(targetType.Name, true, value);

                return value;
            }
        }

        return null;
    }
    
    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}