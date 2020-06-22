using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Pair<TFirst, TSecond>
        : IPropagatePropertyAccessPath
    {
        [Required]
        [JsonPropertyName("first")]
        public TFirst First { get; set; } = default!;

        [Required]
        [JsonPropertyName("second")]
        public TSecond Second { get; set; } = default!;

        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(First)}()", validateHasBeenSet, First);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Second)}()", validateHasBeenSet, Second);
        }
    }
}