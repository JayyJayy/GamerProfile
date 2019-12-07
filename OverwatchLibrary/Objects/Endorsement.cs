using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Endorsement
    {
        [JsonProperty("sportsmanship")]
        public Shotcaller Sportsmanship { get; set; }

        [JsonProperty("shotcaller")]
        public Shotcaller Shotcaller { get; set; }

        [JsonProperty("teammate")]
        public Shotcaller Teammate { get; set; }

        [JsonProperty("level")]
        public object Level { get; set; }

        [JsonProperty("frame")]
        public Uri Frame { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}