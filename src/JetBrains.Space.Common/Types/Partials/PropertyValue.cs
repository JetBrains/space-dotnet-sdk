using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
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
    private readonly string _fieldName;
    private string _accessPath = string.Empty;

    private bool _hasBeenSet;
    private bool _validateHasBeenSet;
        
    private T _value = default!;

    /// <summary>
    /// Creates a new <see cref="PropertyValue{T}"/> instance.
    /// </summary>
    /// <param name="className">The class name as string.</param>
    /// <param name="propertyName">The property name as string.</param>
    /// <param name="fieldName">The field name as represented in the Space API.</param>
    public PropertyValue(string className, string propertyName, string fieldName)
    {
        _className = className;
        _propertyName = propertyName;
        _fieldName = fieldName;
    }

    /// <summary>
    /// Creates a new <see cref="PropertyValue{T}"/> instance with a default value.
    /// </summary>
    /// <param name="className">The class name as string.</param>
    /// <param name="propertyName">The property name as string.</param>
    /// <param name="fieldName">The field name as represented in the Space API.</param>
    /// <param name="initialValue">The property initial value.</param>
    public PropertyValue(string className, string propertyName, string fieldName, T initialValue)
    {
        _className = className;
        _propertyName = propertyName;
        _fieldName = fieldName;
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
    /// <exception cref="PropertyValueInaccessibleException">When property value is not accessible, and property validation is enabled.</exception>
    /// <exception cref="PropertyNotRequestedException">When property value has not been set, and property validation is enabled. This is typically done using the infrastructure in <see cref="IPropagatePropertyAccessPath"/>.</exception>
    [DebuggerHidden]
    public T GetValue(IEnumerable<ApiInlineError> inlineErrors)
    {
        if (_validateHasBeenSet)
        {
            // Is there a known inline error?
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (inlineErrors != null)
            {
                foreach (var inaccessibleFields in inlineErrors.OfType<ApiInlineErrorInaccessibleFields>())
                {
                    if (inaccessibleFields.Fields.Contains(_fieldName))
                    {
                        throw new PropertyValueInaccessibleException(
                            message: $"{inaccessibleFields.Message}. Property {_propertyName} on {_className} is not accessible.", 
                            typeName: _className, 
                            propertyName: _propertyName);
                    }
                }
            }
            
            // Has the property not been set?
            if (!_hasBeenSet) 
            {
                throw new PropertyNotRequestedException(
                    message: $"The property {_propertyName} was not requested in the partial builder for {_className}. Use .With{_propertyName}() to include it. Expected full path: {_accessPath}.With{_propertyName}()",
                    typeName: _className,
                    propertyName: _propertyName);                
            }
        }

        return _value;
    }

    /// <inheritdoc />
    public void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _accessPath = parentChainPath;
        _validateHasBeenSet = validateHasBeenSet;

        PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{parentChainPath}->With{_propertyName}()", validateHasBeenSet, _value);
    }

    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();
}