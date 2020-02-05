using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueLibrary.Models
{
    public class SummonerModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public long ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
    }
}
