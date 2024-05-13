using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// A class that represents a modification structure.
/// </summary>
/// <typeparam name="T">The type of the modified element.</typeparam>
[PublicAPI]
public class Modification<T>
    : IPropagatePropertyAccessPath
{
    /// <summary>
    /// Get/set the old value of the element.
    /// </summary>
    [JsonPropertyName("old")]
    public T? Old { get; set; }
        
    /// <summary>
    /// Get/set the new value of the element.
    /// </summary>
    [JsonPropertyName("new")]
    public T? New { get; set; }

    /// <inheritdoc />
    public void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{parentChainPath}->With{nameof(Old)}()", validateHasBeenSet, Old);
        PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{parentChainPath}->With{nameof(New)}()", validateHasBeenSet, New);
    }

    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();
}