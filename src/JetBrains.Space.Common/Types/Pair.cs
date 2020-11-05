using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types
{
    /// <summary>
    /// A class that represents a pair structure.
    /// </summary>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    [PublicAPI]
    public class Pair<TFirst, TSecond>
        : IPropagatePropertyAccessPath
    {
        /// <summary>
        /// Get/set the first element in the <see cref="Pair{TFirst,TSecond}"/>.
        /// </summary>
        [Required]
        [JsonPropertyName("first")]
        public TFirst First { get; set; } = default!;

        /// <summary>
        /// Get/set the second element in the <see cref="Pair{TFirst,TSecond}"/>.
        /// </summary>
        [Required]
        [JsonPropertyName("second")]
        public TSecond Second { get; set; } = default!;

        /// <inheritdoc />
        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(First)}()", validateHasBeenSet, First);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Second)}()", validateHasBeenSet, Second);
        }
    }
}