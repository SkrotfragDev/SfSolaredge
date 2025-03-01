using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.CurrentPowerFlowModels
{
    public class SolarEdgeCurrentPowerFlow
    {
        [JsonPropertyName("siteCurrentPowerFlow")]
        public SiteCurrentPowerFlow SiteCurrentPowerFlow { get; set; }
    }

    public class SiteCurrentPowerFlow
    {
        [JsonPropertyName("updateRefreshRate")]
        public int UpdateRefreshRate { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("connections")]
        public List<Connection> Connections { get; set; }

        [JsonPropertyName("GRID")]
        public PowerSource GRID { get; set; }

        [JsonPropertyName("LOAD")]
        public PowerSource LOAD { get; set; }

        [JsonPropertyName("PV")]
        public PowerSource PV { get; set; }
    }

    public class Connection
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }
    }

    public class PowerSource
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("currentPower")]
        public double CurrentPower { get; set; }
    }

}
