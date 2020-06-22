using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Modification<T>
        : IPropagatePropertyAccessPath
    {
        [Required]
        [JsonPropertyName("old")]
        public T Old { get; set; } = default!;
        
        [Required]
        [JsonPropertyName("new")]
        public T New { get; set; } = default!;

        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Old)}()", validateHasBeenSet, Old);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(New)}()", validateHasBeenSet, New);
        }
    }
}