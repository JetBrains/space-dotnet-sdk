using System.Collections.Generic;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// Property access path propagation marker and basic infrastructure. Used by generated code.
/// </summary>
[PublicAPI]
public interface IPropagatePropertyAccessPath
{
    /// <summary>
    /// Sets the full property access path for the current instance.
    /// </summary>
    /// <param name="path">The full property access path.</param>
    /// <param name="validateHasBeenSet"><see langword="true" /> when the current instance should validate whether a value has been set; <see langword="false" /> otherwise.</param>
    void SetAccessPath(string path, bool validateHasBeenSet);
}

/// <summary>
/// Extension methods for <see cref="IPropagatePropertyAccessPath"/>.
/// </summary>
public static class PropagatePropertyAccessPathHelper
{
    /// <summary>
    /// Sets the full property access path for <paramref name="value"/>.
    /// </summary>
    /// <param name="path">The full property access path.</param>
    /// <param name="validateHasBeenSet"><see langword="true" /> when the current instance should validate whether a value has been set; <see langword="false" /> otherwise.</param>
    /// <param name="value">The value to set the full property access path for.</param>
    /// <typeparam name="T">Any type. When the type is a <see cref="IPropagatePropertyAccessPath"/>, the logic will be executed.</typeparam>
    public static void SetAccessPathForValue<T>(string path, bool validateHasBeenSet, T value)
    {
        if (value == null) return;

        switch (value)
        {
            case IPropagatePropertyAccessPath valueWithPropertyAccessValidation:
                valueWithPropertyAccessValidation.SetAccessPath(path, validateHasBeenSet);
                break;

            case IEnumerable<IPropagatePropertyAccessPath> enumerable:
            {
                foreach (var item in enumerable)
                {
                    item.SetAccessPath(path, validateHasBeenSet);
                }

                break;
            }
        }
    }
}