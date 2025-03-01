using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.SolarEdgeOverviewData
{
    public class SolarEdgeOverviewData
    {
        [JsonPropertyName("overview")]
        public Overview Overview { get; set; }
    }

    public class Overview
    {
        [JsonPropertyName("lastUpdateTime")]
        public string LastUpdateTime { get; set; }

        [JsonPropertyName("lifeTimeData")]
        public EnergyData LifeTimeData { get; set; }

        [JsonPropertyName("lastYearData")]
        public EnergyData LastYearData { get; set; }

        [JsonPropertyName("lastMonthData")]
        public EnergyData LastMonthData { get; set; }

        [JsonPropertyName("lastDayData")]
        public EnergyData LastDayData { get; set; }

        [JsonPropertyName("currentPower")]
        public PowerData CurrentPower { get; set; }

        [JsonPropertyName("measuredBy")]
        public string MeasuredBy { get; set; }
    }

    public class EnergyData
    {
        [JsonPropertyName("energy")]
        public double Energy { get; set; }
    }

    public class PowerData
    {
        [JsonPropertyName("power")]
        public double Power { get; set; }
    }
}
