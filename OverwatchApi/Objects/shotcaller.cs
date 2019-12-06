using Newtonsoft.Json;

namespace OverwatchApi.Objects
{
    public class Shotcaller
    {
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rate { get; set; }
    }
}