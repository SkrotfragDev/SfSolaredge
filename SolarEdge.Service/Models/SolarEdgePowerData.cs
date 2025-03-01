using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models
{
    public class SolarEdgePowerData
    {
        [JsonPropertyName("power")]
        public PowerData Power { get; set; }
    }

    public class PowerData
    {
        [JsonPropertyName("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("values")]
        public List<PowerValue> Values { get; set; }
    }

    public class PowerValue
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; } 
    }

}
