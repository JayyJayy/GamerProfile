using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Games
    {
        [JsonProperty("quickplay")]
        public Quickplay Quickplay { get; set; }

        [JsonProperty("competitive")]
        public Comp Competitive { get; set; }
    }
}