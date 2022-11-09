using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization.Internal;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

#nullable disable

namespace JetBrains.Space.Common.Json.Serialization;

/// <summary>
/// A <see cref="JsonConverterFactory"/> that can (de)serialize an instance of <see cref="IUrlParameter"/>.
/// </summary>
public class UrlParameterConverter : JsonConverterFactory
{
    private readonly Type _genericConverterType = typeof(UrlParameterConverter<>);
    
    /// <inheritdoc />
    public override bool CanConvert(Type objectType)
        => typeof(IUrlParameter).IsAssignableFrom(objectType);
    
    /// <inheritdoc />
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var constructedType = _genericConverterType.MakeGenericType(typeToConvert);
        return (Activator.CreateInstance(constructedType) as JsonConverter)!;
    }
}

/// <summary>
/// A <see cref="JsonConverter{T}"/> that can (de)serialize an instance of <see cref="IUrlParameter"/>.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> to convert.</typeparam>
public class UrlParameterConverter<T> : JsonConverter<T>
    where T : class, IUrlParameter
{
    /// <inheritdoc />
    public override bool CanConvert(Type objectType)
        => typeof(IUrlParameter).IsAssignableFrom(objectType);
        
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
                    spaceDotNetCSharpTypeName: ClassNameTypeUtility.SpaceDotNetClientNamespace + "." + typeToConvert.Name + "+" + CSharpIdentifier.ForClassOrNamespace(className) + ", " + ClassNameTypeUtility.SpaceDotNetClientAssemblyName,
                    targetType: out var targetType))
            {
                return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as T;
            }
        }
        
        JsonDocument.ParseValue(ref readerAtStart).Dispose();
        return null;
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}