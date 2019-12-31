using Newtonsoft.Json;

namespace SpaceDotNet.Client
{
    /// <summary>
    /// Represents an error retrieved from Space.
    /// </summary>
    public class SpaceError
    {
        /// <summary>
        /// Short description of the error.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
        
        /// <summary>
        /// Full description of the error.
        /// </summary>
        [JsonProperty("error_description")]
        public string Description { get; set; }
    }
}