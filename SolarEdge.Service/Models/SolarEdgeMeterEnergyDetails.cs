using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.SolarEdgeMeterEnergyDetails
{
    public class SolarEdgeMeterEnergyDetails
    {
        [JsonPropertyName("meterEnergyDetails")]
        public MeterEnergyDetails MeterEnergyDetails { get; set; }
    }

    public class MeterEnergyDetails
    {
        [JsonPropertyName("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("meters")]
        public List<MeterEnergy> Meters { get; set; }
    }

    public class MeterEnergy
    {
        [JsonPropertyName("meterSerialNumber")]
        public string MeterSerialNumber { get; set; }

        [JsonPropertyName("connectedSolaredgeDeviceSN")]
        public string ConnectedSolaredgeDeviceSN { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("meterType")]
        public string MeterType { get; set; }

        [JsonPropertyName("values")]
        public List<MeterEnergyValue> Values { get; set; }
    }

    public class MeterEnergyValue
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}
