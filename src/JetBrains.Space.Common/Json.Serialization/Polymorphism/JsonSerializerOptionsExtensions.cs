using System.Text.Json;

namespace JetBrains.Space.Common.Json.Serialization.Polymorphism
{
    /// <summary>
    /// Extension methods for <see cref="JsonSerializerOptions"/>.
    /// </summary>
    public static class JsonSerializerOptionsExtensions
    {
        /// <summary>
        /// Registers Space-specific JSON serializer options.
        /// </summary>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> to customize.</param>
        /// <returns>The customized <see cref="JsonSerializerOptions"/>.</returns>
        public static JsonSerializerOptions AddSpaceJsonTypeConverters(this JsonSerializerOptions options)
        {
            options.Converters.Add(new ClassNameInterfaceDtoTypeConverter());
            options.Converters.Add(new ListOfClassNameDtoTypeConverter());
            options.Converters.Add(new ListOfEnumerationConverter());
            return options;
        }
    }
}