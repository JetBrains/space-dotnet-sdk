using System.Text.Json;

namespace SpaceDotNet.Common.Json.Serialization.Polymorphism
{
    public static class JsonSerializerOptionsExtensions
    {
        public static JsonSerializerOptions AddSpacePolymorphismConverters(this JsonSerializerOptions options)
        {
            options.Converters.Add(new ClassNameInterfaceDtoTypeConverter());
            options.Converters.Add(new ListOfClassNameInterfaceDtoTypeConverter());
            return options;
        }
    }
}