using System;
using SpaceDotNet.Common.Types;

#nullable disable

namespace SpaceDotNet.Common.Json.Serialization.Polymorphism
{
    public class ListOfClassNameDtoTypeConverter : ListOfTypeConverter<IClassNameConvertible>
    {
        public ListOfClassNameDtoTypeConverter() : base(new ClassNameInterfaceDtoTypeConverter())
        {
        }
    }
    
    public class ClassNameInterfaceDtoTypeConverter : ClassNameDtoTypeConverter
    {
        public override bool CanConvert(Type objectType) 
            => objectType.IsInterface && objectType.Namespace == SpaceDotNetClientNamespace && objectType.FullName != null && objectType.FullName.EndsWith("Dto");
    }
}