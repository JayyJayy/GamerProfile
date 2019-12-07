using System;
using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Playtime
    {
        [JsonProperty("quickplay", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Quickplay { get; set; }

        [JsonProperty("competitive", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Competitive { get; set; }
    }
}