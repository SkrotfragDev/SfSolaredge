using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.SolarEdgeEnergyDetails
{
    public class SolarEdgeEnergyDetails
    {
        [JsonPropertyName("energyDetails")]
        public EnergyDetails EnergyDetails { get; set; }
    }

    public class EnergyDetails
    {
        [JsonPropertyName("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("meters")]
        public List<Meter> Meters { get; set; }
    }

    public class Meter
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("values")]
        public List<MeterValue> Values { get; set; }
    }

    public class MeterValue
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; } // Nullable because some values might be null
    }
}
