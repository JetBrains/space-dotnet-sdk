using System.Text.Json;

namespace JetBrains.Space.Common.Json.Serialization;

/// <summary>
/// Extension methods for <see cref="JsonElement"/>.
/// </summary>
public static class JsonElementExtensions
{
    /// <summary>
    /// Gets an <see cref="string"/> from a <see cref="JsonElement"/>.
    /// </summary>
    /// <param name="jsonElement">The <see cref="JsonElement"/> input.</param>
    /// <param name="propertyName">The property name to get a <see cref="string"/> from.</param>
    /// <returns>A <see cref="string"/> from the <paramref name="propertyName"/> property of a <see cref="JsonElement"/>.</returns>
    public static string? GetStringValue(this JsonElement jsonElement, string propertyName) 
        => jsonElement.TryGetProperty(propertyName, out var propertyElement) ? propertyElement.GetString() : null;
        
    /// <summary>
    /// Gets an <see cref="int"/> from a <see cref="JsonElement"/>.
    /// </summary>
    /// <param name="jsonElement">The <see cref="JsonElement"/> input.</param>
    /// <param name="propertyName">The property name to get an <see cref="int"/> from.</param>
    /// <returns>An <see cref="int"/> from the <paramref name="propertyName"/> property of a <see cref="JsonElement"/>.</returns>
    public static int GetInt32Value(this JsonElement jsonElement, string propertyName) 
        => jsonElement.TryGetProperty(propertyName, out var propertyElement) ? propertyElement.GetInt32() : default;
}