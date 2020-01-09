using System;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Common.Types
{
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
    }
}