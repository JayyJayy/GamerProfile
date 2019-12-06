using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Comp
    {
        [JsonProperty("won", NullValueHandling = NullValueHandling.Ignore)]
        public long? Won { get; set; }

        [JsonProperty("lost", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lost { get; set; }

        [JsonProperty("draw", NullValueHandling = NullValueHandling.Ignore)]
        public long? Draw { get; set; }

        [JsonProperty("played", NullValueHandling = NullValueHandling.Ignore)]
        public long? Played { get; set; }

        [JsonProperty("win_rate")]
        public object WinRate { get; set; }
    }
}