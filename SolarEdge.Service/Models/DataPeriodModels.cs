using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.DataPeriodModels
{
    public class SolarEdgeDataPeriod
    {
        [JsonPropertyName("dataPeriod")]
        public DataPeriod DataPeriod { get; set; }
    }

    public class DataPeriod
    {
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }
    }
}
