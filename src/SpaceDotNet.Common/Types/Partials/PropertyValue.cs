using System.Diagnostics;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// Property value backing field type for Dtos.
    /// Throws a <see cref="PropertyAccessException"/> when accessing a property
    /// that has not been requested from the API.
    /// </summary>
    /// <remarks>Should only be used in generated code.</remarks>
    /// <typeparam name="T">Type for the Dto backing field.</typeparam>
    [PublicAPI]
    public sealed class PropertyValue<T>
    {
        private readonly string _className;
        private readonly string _propertyName;

        private T _value = default!;
        private bool _hasBeenSet;

        public PropertyValue(string className, string propertyName)
        {
            _className = className;
            _propertyName = propertyName;
        }

        [DebuggerHidden]
        public void SetValue(T value)
        {
            _value = value;
            _hasBeenSet = true;
        }

        [DebuggerHidden]
        public T GetValue()
        {
            if (!_hasBeenSet)
            {
                throw new PropertyAccessException($"The property {_propertyName} was not requested in the partial builder for {_className}. Use .With{_propertyName}() to include it.", _className, _propertyName);
            }
            return _value;
        }
    }
}