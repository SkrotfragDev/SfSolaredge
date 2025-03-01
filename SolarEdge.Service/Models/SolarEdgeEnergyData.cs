using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models
{
    public class SolarEdgeEnergyData
    {
        [JsonPropertyName("energy")]
        public EnergyData Energy { get; set; }
    }

    public class EnergyData
    {
        [JsonPropertyName("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("values")]
        public List<EnergyValue> Values { get; set; }
    }

    public class EnergyValue
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}
