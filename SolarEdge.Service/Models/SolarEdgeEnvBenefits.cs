using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models.SolarEdgeEnvBenefits
{
    public class SolarEdgeEnvBenefits
    {
        [JsonPropertyName("envBenefits")]
        public EnvBenefits EnvBenefits { get; set; }
    }

    public class EnvBenefits
    {
        [JsonPropertyName("gasEmissionSaved")]
        public GasEmissionSaved GasEmissionSaved { get; set; }

        [JsonPropertyName("treesPlanted")]
        public double TreesPlanted { get; set; }

        [JsonPropertyName("lightBulbs")]
        public double LightBulbs { get; set; }
    }

    public class GasEmissionSaved
    {
        [JsonPropertyName("units")]
        public string Units { get; set; }

        [JsonPropertyName("co2")]
        public double Co2 { get; set; }

        [JsonPropertyName("so2")]
        public double So2 { get; set; }

        [JsonPropertyName("nox")]
        public double Nox { get; set; }
    }
}
