using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class MapEntry<TKey, TValue>
        : IPropagatePropertyAccessPath
    {
        [Required]
        [JsonPropertyName("key")]
        public TKey Key { get; set; } = default!;

        [Required]
        [JsonPropertyName("value")]
        public TValue Value { get; set; } = default!;

        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Key)}()", validateHasBeenSet, Key);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Value)}()", validateHasBeenSet, Value);
        }
    }
}