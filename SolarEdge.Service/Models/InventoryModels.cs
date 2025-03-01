using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.InventoryModels
{
    public class SolarEdgeInventory
    {
        [JsonPropertyName("Inventory")]
        public Inventory Inventory { get; set; }
    }

    public class Inventory
    {
        [JsonPropertyName("inverters")]
        public List<Inverter> Inverters { get; set; }

        [JsonPropertyName("thirdPartyInverters")]
        public List<ThirdPartyInverter> ThirdPartyInverters { get; set; }

        [JsonPropertyName("smiList")]
        public List<SMIDevice> SmiList { get; set; }

        [JsonPropertyName("meters")]
        public List<Meter> Meters { get; set; }

        [JsonPropertyName("sensors")]
        public List<Sensor> Sensors { get; set; }

        [JsonPropertyName("gateways")]
        public List<Gateway> Gateways { get; set; }

        [JsonPropertyName("batteries")]
        public List<Battery> Batteries { get; set; }
    }

    public class Inverter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonPropertyName("cpuVersion")]
        public string CpuVersion { get; set; }

        [JsonPropertyName("dsp1Version")]
        public string Dsp1Version { get; set; }

        [JsonPropertyName("dsp2Version")]
        public string Dsp2Version { get; set; }

        [JsonPropertyName("communicationMethod")]
        public string CommunicationMethod { get; set; }

        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("connectedOptimizers")]
        public int ConnectedOptimizers { get; set; }
    }

    public class ThirdPartyInverter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("SN")]
        public string SerialNumber { get; set; }
    }

    public class SMIDevice
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonPropertyName("communicationMethod")]
        public string CommunicationMethod { get; set; }

        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    }

    public class Meter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonPropertyName("connectedTo")]
        public string ConnectedTo { get; set; }

        [JsonPropertyName("connectedSolaredgeDeviceSN")]
        public string ConnectedSolaredgeDeviceSN { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("SN")]
        public string SerialNumber { get; set; }
    }

    public class Sensor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("connectedSolaredgeDeviceSN")]
        public string ConnectedSolaredgeDeviceSN { get; set; }

        [JsonPropertyName("connectedTo")]
        public string ConnectedTo { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Gateway
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonPropertyName("SN")]
        public string SerialNumber { get; set; }
    }

    public class Battery
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("nameplateCapacity")]
        public double NameplateCapacity { get; set; }

        [JsonPropertyName("connectedTo")]
        public string ConnectedTo { get; set; }

        [JsonPropertyName("connectedSolaredgeDeviceSN")]
        public string ConnectedSolaredgeDeviceSN { get; set; }
    }
}

