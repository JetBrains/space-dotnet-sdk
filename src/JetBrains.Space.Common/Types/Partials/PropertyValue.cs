using System.Diagnostics;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// Property value backing field type for Dtos.
/// Throws a <see cref="PropertyNotRequestedException"/> when accessing a property
/// that has not been requested from the API.
/// </summary>
/// <remarks>Should only be used in generated code.</remarks>
/// <typeparam name="T">Type for the Dto backing field.</typeparam>
[PublicAPI]
public sealed class PropertyValue<T> 
    : IPropagatePropertyAccessPath
{
    private readonly string _className;
    private readonly string _propertyName;
    private string _accessPath = string.Empty;

    private bool _hasBeenSet;
    private bool _validateHasBeenSet;
        
    private T _value = default!;

    /// <summary>
    /// Creates a new <see cref="PropertyValue{T}"/> instance.
    /// </summary>
    /// <param name="className">The class name as string.</param>
    /// <param name="propertyName">The property name as string.</param>
    public PropertyValue(string className, string propertyName)
    {
        _className = className;
        _propertyName = propertyName;
    }

    /// <summary>
    /// Creates a new <see cref="PropertyValue{T}"/> instance with a default value.
    /// </summary>
    /// <param name="className">The class name as string.</param>
    /// <param name="propertyName">The property name as string.</param>
    /// <param name="initialValue">The property initial value.</param>
    public PropertyValue(string className, string propertyName, T initialValue)
    {
        _className = className;
        _propertyName = propertyName;
        _value = initialValue;
        _hasBeenSet = true;
    }

    /// <summary>
    /// Sets the value for this property.
    /// </summary>
    /// <param name="value">The property value.</param>
    [DebuggerHidden]
    public void SetValue(T value)
    {
        _value = value;
        _hasBeenSet = true;
    }
        
    /// <summary>
    /// Gets the value for this property.
    /// </summary>
    /// <returns>The property value.</returns>
    /// <exception cref="PropertyNotRequestedException">When property value has not been set, and property validation is enabled. This is typically done using th infrastructure in <see cref="IPropagatePropertyAccessPath"/>.</exception>
    [DebuggerHidden]
    public T GetValue()
    {
        if (!_hasBeenSet)
        {
            if (_validateHasBeenSet)
            {
                throw new PropertyNotRequestedException($"The property {_propertyName} was not requested in the partial builder for {_className}. Use .With{_propertyName}() to include it. Expected full path: {_accessPath}.With{_propertyName}()", _className, _propertyName);                
            }
            else
            {
                // TODO log
            }
        }
        return _value;
    }

    /// <inheritdoc />
    public void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _accessPath = path;
        _validateHasBeenSet = validateHasBeenSet;
            
        PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{_propertyName}()", validateHasBeenSet, _value);
    }
}