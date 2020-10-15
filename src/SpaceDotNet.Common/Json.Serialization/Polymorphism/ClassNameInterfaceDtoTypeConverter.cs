using System;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Types;

#nullable disable

namespace SpaceDotNet.Common.Json.Serialization.Polymorphism
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that can (de)serialize an collection of <see cref="IClassNameConvertible"/>.
    /// </summary>
    public class ListOfClassNameDtoTypeConverter : ListOfTypeConverter<IClassNameConvertible>
    {
        /// <summary>
        /// Creates a new <see cref="ListOfClassNameDtoTypeConverter"/> instance.
        /// </summary>
        public ListOfClassNameDtoTypeConverter() : base(new ClassNameInterfaceDtoTypeConverter())
        {
        }
    }
    
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that can (de)serialize an instance of <see cref="IClassNameConvertible"/>.
    /// </summary>
    public class ClassNameInterfaceDtoTypeConverter : ClassNameDtoTypeConverter
    {
        /// <inheritdoc />
        public override bool CanConvert(Type objectType) 
            => objectType.IsInterface && objectType.Namespace == SpaceDotNetClientNamespace && objectType.FullName != null;
    }
}