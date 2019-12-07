using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Comp
    {
        [JsonProperty("won")]
        public long? Won { get; set; }

        [JsonProperty("lost")]
        public long? Lost { get; set; }

        [JsonProperty("draw")]
        public long? Draw { get; set; }

        [JsonProperty("played")]
        public long? Played { get; set; }

        [JsonProperty("win_rate")]
        public object WinRate { get; set; }
    }
}