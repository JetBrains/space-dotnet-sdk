using System;
using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown by <see cref="PropertyValue{T}" /> when
/// accessing a property that has not been requested from the API.
/// </summary>
[PublicAPI]
public class PropertyNotRequestedException 
    : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="T:PropertyAccessException" /> class with a specific message.
    /// </summary>
    /// <param name="message">A message that describes the current exception.</param>
    /// <param name="typeName">The Dto type name on which an uninitialized property was accessed.</param>
    /// <param name="propertyName">The uninitialized property name.</param>
    public PropertyNotRequestedException(string message, string typeName, string propertyName) 
        : base(message)
    {
        TypeName = typeName;
        PropertyName = propertyName;
    }
        
    /// <summary>
    /// Get the Dto type name on which an uninitialized property was accessed.
    /// </summary>
    public string TypeName { get; }

    /// <summary>
    /// Get the uninitialized property name.
    /// </summary>
    public string PropertyName { get; }
}