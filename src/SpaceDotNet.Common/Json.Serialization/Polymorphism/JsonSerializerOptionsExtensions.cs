using System.Text.Json;

namespace SpaceDotNet.Common.Json.Serialization.Polymorphism
{
    public static class JsonSerializerOptionsExtensions
    {
        public static JsonSerializerOptions AddSpaceJsonTypeConverters(this JsonSerializerOptions options)
        {
            options.Converters.Add(new ClassNameInterfaceDtoTypeConverter());
            options.Converters.Add(new ListOfClassNameDtoTypeConverter());
            options.Converters.Add(new ListOfEnumerationConverter());
            return options;
        }
    }
}