using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.SolarEdgeStorageData
{
    public class SolarEdgeStorageData
    {
        [JsonPropertyName("storageData")]
        public StorageData StorageData { get; set; }
    }

    public class StorageData
    {
        [JsonPropertyName("batteryCount")]
        public int BatteryCount { get; set; }

        [JsonPropertyName("batteries")]
        public List<Battery> Batteries { get; set; }
    }

    public class Battery
    {
        [JsonPropertyName("nameplate")]
        public int Nameplate { get; set; }

        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonPropertyName("telemetryCount")]
        public int TelemetryCount { get; set; }

        [JsonPropertyName("telemetries")]
        public List<Telemetry> Telemetries { get; set; }
    }

    public class Telemetry
    {
        [JsonPropertyName("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonPropertyName("power")]
        public int Power { get; set; }

        [JsonPropertyName("batteryState")]
        public int BatteryState { get; set; }

        [JsonPropertyName("lifeTimeEnergyCharged")]
        public int LifeTimeEnergyCharged { get; set; }

        [JsonPropertyName("lifeTimeEnergyDischarged")]
        public int LifeTimeEnergyDischarged { get; set; }

        [JsonPropertyName("fullPackEnergyAvailable")]
        public int FullPackEnergyAvailable { get; set; }

        [JsonPropertyName("internalTemp")]
        public int InternalTemp { get; set; }

        [JsonPropertyName("ACGridCharging")]
        public int ACGridCharging { get; set; }
    }
}

