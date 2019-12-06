using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Endorsement
    {
        [JsonProperty("sportsmanship", NullValueHandling = NullValueHandling.Ignore)]
        public Shotcaller Sportsmanship { get; set; }

        [JsonProperty("shotcaller", NullValueHandling = NullValueHandling.Ignore)]
        public Shotcaller Shotcaller { get; set; }

        [JsonProperty("teammate", NullValueHandling = NullValueHandling.Ignore)]
        public Shotcaller Teammate { get; set; }

        [JsonProperty("level")]
        public object Level { get; set; }

        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Frame { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }
    }
}