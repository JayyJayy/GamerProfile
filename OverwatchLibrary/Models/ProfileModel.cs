using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using OverwatchLibrary.Objects;

namespace OverwatchLibrary.Models
{
    public class ProfileModel
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("level")]
        public long? Level { get; set; }

        [JsonProperty("portrait")]
        public Uri Portrait { get; set; }

        [JsonProperty("endorsement")]
        public Endorsement Endorsement { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("games")]
        public Games Games { get; set; }

        [JsonProperty("playtime")]
        public Playtime Playtime { get; set; }

        [JsonProperty("competitive")]
        public Competitive Competitive { get; set; }

        [JsonProperty("levelFrame")]
        public Uri LevelFrame { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        public decimal WinRatioCalculator(long? wins, long? loses)
        {
            decimal ratio = Convert.ToDecimal(wins) / Convert.ToDecimal(loses);
            decimal test = 31 / 8;
            return Math.Round(ratio, 2);
        }
    }
}