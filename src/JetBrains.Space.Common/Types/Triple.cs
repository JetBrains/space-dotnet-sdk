using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types
{
    /// <summary>
    /// A class that represents a triple structure.
    /// </summary>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TThird">The type of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    [PublicAPI]
    public class Triple<TFirst, TSecond, TThird>
        : IPropagatePropertyAccessPath
    {
        /// <summary>
        /// Get/set the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
        /// </summary>
        [Required]
        [JsonPropertyName("first")]
        public TFirst First { get; set; } = default!;

        /// <summary>
        /// Get/set the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
        /// </summary>
        [Required]
        [JsonPropertyName("second")]
        public TSecond Second { get; set; } = default!;

        /// <summary>
        /// Get/set the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
        /// </summary>
        [Required]
        [JsonPropertyName("third")]
        public TThird Third { get; set; } = default!;

        /// <inheritdoc />
        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(First)}()", validateHasBeenSet, First);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Second)}()", validateHasBeenSet, Second);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Third)}()", validateHasBeenSet, Third);
        }
    }
}