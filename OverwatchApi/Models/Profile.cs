using System;
using System.Runtime.Serialization;
using OverwatchApi.Objects;

namespace OverwatchApi.Models
{
    [DataContract]
    public class Profile
    {
        public string UserName { get; set; }
        public int Level { get; set; }
        public Uri Portrait { get; set; }
        public Endorsement Endorsement { get; set; }
        public bool PrivateProfile { get; set; }
        public Games Games { get; set; }
        public Playtime Playtime { get; set; }
        public Uri LevelFrame { get; set; }
       

    }
}