using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using OverwatchApi.Objects;

namespace OverwatchApi.Models
{
    public class ProfileModel
    {
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public long? Level { get; set; }

        [JsonProperty("portrait", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Portrait { get; set; }

        [JsonProperty("endorsement", NullValueHandling = NullValueHandling.Ignore)]
        public Endorsement Endorsement { get; set; }

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        [JsonProperty("games", NullValueHandling = NullValueHandling.Ignore)]
        public Games Games { get; set; }

        [JsonProperty("playtime", NullValueHandling = NullValueHandling.Ignore)]
        public Playtime Playtime { get; set; }

        [JsonProperty("competitive", NullValueHandling = NullValueHandling.Ignore)]
        public Competitive Competitive { get; set; }

        [JsonProperty("levelFrame", NullValueHandling = NullValueHandling.Ignore)]
        public Uri LevelFrame { get; set; }
    }
}