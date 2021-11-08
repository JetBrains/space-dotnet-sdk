using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

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
        JsonDocument.ParseValue(ref reader).Dispose();
        return null!;
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}