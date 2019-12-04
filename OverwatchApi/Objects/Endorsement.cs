using System.Collections.Generic;

namespace OverwatchApi.Objects
{
    public class Endorsement
    {
        public Dictionary<int,int> Sportsmanship { get; set; }
        public Dictionary<int,int> Shotcaller { get; set; }
        public Dictionary<int,int> Teammate { get; set; }
    }
}