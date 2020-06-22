using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Batch<T> 
        : IPropagatePropertyAccessPath
    {
        [JsonPropertyName("data")]
        public List<T>? Data { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        public bool HasNext() => TotalCount != null && !string.IsNullOrEmpty(Next) && Next != TotalCount.ToString();
        
        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Data)}()", validateHasBeenSet, Data);
        }
    }
}