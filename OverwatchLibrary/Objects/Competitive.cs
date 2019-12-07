using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Competitive
    {
        [JsonProperty("tank")]
        public Damage Tank { get; set; }

        [JsonProperty("damage")]
        public Damage Damage { get; set; }

        [JsonProperty("support")]
        public Damage Support { get; set; }
    }
}