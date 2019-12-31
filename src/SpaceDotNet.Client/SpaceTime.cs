using System;
using Newtonsoft.Json;

namespace SpaceDotNet.Client
{
    public class SpaceTime
    {
        [JsonProperty("iso")]
        public string Iso { get; set; }
        
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime AsDateTime() => DateTimeOffset.FromUnixTimeSeconds(Timestamp).DateTime;
    }
}