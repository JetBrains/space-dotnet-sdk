using System.Text.Json;

namespace SpaceDotNet.Common.Json.Serialization
{
    public static class JsonElementExtensions
    {
        public static string? GetStringValue(this JsonElement jsonElement, string propertyName) 
            => jsonElement.TryGetProperty(propertyName, out var propertyElement) ? propertyElement.GetString() : null;
        
        public static int GetInt32Value(this JsonElement jsonElement, string propertyName) 
            => jsonElement.TryGetProperty(propertyName, out var propertyElement) ? propertyElement.GetInt32() : default;
    }
}