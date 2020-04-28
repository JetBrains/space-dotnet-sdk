using System;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class SpaceDate
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
        
        [JsonPropertyName("year")]
        public int Year { get; set; }
        
        [JsonPropertyName("month")]
        public int Month { get; set; }
        
        [JsonPropertyName("day")]
        public int Day { get; set; }

        public DateTime AsDateTime() => new DateTime(Year, Month, Day);

        public override string ToString()
        {
            return AsDateTime().ToString("o");
        }
    }
}