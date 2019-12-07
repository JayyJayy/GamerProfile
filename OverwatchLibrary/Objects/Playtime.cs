using System;
using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Playtime
    {
        [JsonProperty("quickplay")]
        public DateTimeOffset? Quickplay { get; set; }

        [JsonProperty("competitive")]
        public DateTimeOffset? Competitive { get; set; }
    }
}