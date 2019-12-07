using System;
using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Damage
    {
        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("rank_img")]
        public Uri RankImg { get; set; }
    }
}