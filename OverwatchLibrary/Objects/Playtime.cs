using System;
using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Playtime
    {
        [JsonProperty("quickplay")]
        public string Quickplay { get; set; }

        [JsonProperty("competitive")]
        public string Competitive { get; set; }
    }
}