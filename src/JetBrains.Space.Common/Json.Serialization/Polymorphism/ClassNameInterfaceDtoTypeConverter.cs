using System;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Types;

#nullable disable

namespace JetBrains.Space.Common.Json.Serialization.Polymorphism
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that can (de)serialize an collection of <see cref="IClassNameConvertible"/>.
    /// </summary>
    public class ListOfClassNameDtoTypeConverter : ListOfTypeConverter<IClassNameConvertible>
    {
        /// <summary>
        /// Creates a new <see cref="ListOfClassNameDtoTypeConverter"/> instance.
        /// </summary>
        public ListOfClassNameDtoTypeConverter() : base(new ClassNameDtoTypeConverter<IClassNameConvertible>())
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