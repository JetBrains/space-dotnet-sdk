using System;
using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown by <see cref="PropertyValue{T}" /> when
/// accessing a property that is inaccessible.
/// </summary>
[PublicAPI]
public class PropertyValueInaccessibleException 
    : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="T:PropertyValueInaccessibleException" /> class with a specific message.
    /// </summary>
    /// <param name="message">A message that describes the current exception.</param>
    /// <param name="typeName">The Dto type name on which an inaccessible property was accessed.</param>
    /// <param name="propertyName">The inaccessible property name.</param>
    public PropertyValueInaccessibleException(string message, string typeName, string propertyName) 
        : base(message)
    {
        TypeName = typeName;
        PropertyName = propertyName;
    }
        
    /// <summary>
    /// Get the Dto type name on which an inaccessible property was accessed.
    /// </summary>
    public string TypeName { get; }

    /// <summary>
    /// Get the inaccessible property name.
    /// </summary>
    public string PropertyName { get; }
}