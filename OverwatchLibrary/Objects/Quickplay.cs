using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Quickplay
    {
        [JsonProperty("won")]
        public long? Won { get; set; }
    }
}