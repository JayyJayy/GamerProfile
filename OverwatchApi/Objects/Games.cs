using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Games
    {
        [JsonProperty("quickplay", NullValueHandling = NullValueHandling.Ignore)]
        public Quickplay Quickplay { get; set; }

        [JsonProperty("competitive", NullValueHandling = NullValueHandling.Ignore)]
        public Comp Competitive { get; set; }
    }
}