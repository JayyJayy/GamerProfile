using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Quickplay
    {
        [JsonProperty("won", NullValueHandling = NullValueHandling.Ignore)]
        public long? Won { get; set; }
    }
}