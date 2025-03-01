using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.EquipmentModels
{
    public class SolarEdgeEquipmentList
    {
        [JsonPropertyName("reporters")]
        public EquipmentReporters Reporters { get; set; }
    }

    public class EquipmentReporters
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("list")]
        public List<EquipmentItem> List { get; set; }
    }

    public class EquipmentItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("kWpDC")]
        public double? KWpDC { get; set; } // Nullable because it may be null in JSON
    }
}

