using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Competitive
    {
        [JsonProperty("tank", NullValueHandling = NullValueHandling.Ignore)]
        public Damage Tank { get; set; }

        [JsonProperty("damage", NullValueHandling = NullValueHandling.Ignore)]
        public Damage Damage { get; set; }

        [JsonProperty("support", NullValueHandling = NullValueHandling.Ignore)]
        public Damage Support { get; set; }
    }
}