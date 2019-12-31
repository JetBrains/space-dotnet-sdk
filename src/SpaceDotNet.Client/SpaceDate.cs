using System;
using Newtonsoft.Json;

namespace SpaceDotNet.Client
{
    public class SpaceDate
    {
        [JsonProperty("iso")]
        public string Iso { get; set; }
        
        [JsonProperty("year")]
        public int Year { get; set; }
        
        [JsonProperty("month")]
        public int Month { get; set; }
        
        [JsonProperty("day")]
        public int Day { get; set; }

        public DateTime AsDateTime() => new DateTime(Year, Month, Day);
    }
}