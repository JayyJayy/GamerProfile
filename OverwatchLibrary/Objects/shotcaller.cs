using Newtonsoft.Json;

namespace OverwatchLibrary.Objects
{
    public class Shotcaller
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("rate")]
        public long? Rate { get; set; }
    }
}