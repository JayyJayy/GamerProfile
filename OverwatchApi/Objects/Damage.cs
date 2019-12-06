using System;
using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Damage
    {
        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("rank_img")]
        public Uri RankImg { get; set; }
    }
}