using System.Collections.Generic;
using System.Text.Json.Serialization;
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
    /// <param name="parentChainPath">The parent reference chain path.</param>
    /// <param name="validateHasBeenSet"><see langword="true" /> when the current instance should validate whether a value has been set; <see langword="false" /> otherwise.</param>
    void SetAccessPath(string parentChainPath, bool validateHasBeenSet);

    /// <summary>
    /// Inline errors from the Space API (HA_InlineError).
    /// </summary>
    [JsonPropertyName("$errors")]
    List<ApiInlineError> InlineErrors { get; set; }
}

/// <summary>
/// Extension methods for <see cref="IPropagatePropertyAccessPath"/>.
/// </summary>
public static class PropagatePropertyAccessPathHelper
{
    /// <summary>
    /// Sets the full property access path for <paramref name="value"/>.
    /// </summary>
    /// <param name="parentChainPath">The parent reference chain path.</param>
    /// <param name="validateHasBeenSet"><see langword="true" /> when the current instance should validate whether a value has been set; <see langword="false" /> otherwise.</param>
    /// <param name="value">The value to set the full property access path on.</param>
    /// <typeparam name="T">Any type. When the type is a <see cref="IPropagatePropertyAccessPath"/>, the logic will be executed.</typeparam>
    public static void SetAccessPathForValue<T>(string parentChainPath, bool validateHasBeenSet, T value)
    {
        if (value == null) return;

        switch (value)
        {
            case IPropagatePropertyAccessPath valueWithPropertyAccessValidation:
                valueWithPropertyAccessValidation.SetAccessPath(parentChainPath, validateHasBeenSet);
                break;

            case IEnumerable<IPropagatePropertyAccessPath> enumerable:
            {
                foreach (var item in enumerable)
                {
                    item.SetAccessPath(parentChainPath, validateHasBeenSet);
                }

                break;
            }
        }
    }
}