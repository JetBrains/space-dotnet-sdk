using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types
{
    /// <summary>
    /// Marker interface for classes that support polymorphic JSON (de)serialization.
    /// </summary>
    [PublicAPI]
    public interface IClassNameConvertible
    {
        /// <summary>
        /// Represents the class name that will be (de)serialized.
        /// </summary>
        string? ClassName { get; }
    }
}