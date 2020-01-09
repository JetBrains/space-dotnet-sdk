using System;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Common.Types
{
    public class SpaceTime
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
        
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        public DateTime AsDateTime() => DateTimeOffset.FromUnixTimeSeconds(Timestamp).DateTime;
    }
}