using System;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class SpaceTime
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; } = default!;
        
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        public DateTime AsDateTime() => DateTimeOffset.FromUnixTimeSeconds(Timestamp).DateTime;

        public override string ToString()
        {
            return AsDateTime().ToString("o");
        }
    }
}