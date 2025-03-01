using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SolarEdge.Service.Models
{
    namespace SolarEdge.Service.Models.SiteListModels
    {
        public class SolarEdgeSiteList
        {
            [JsonPropertyName("sites")]
            public Sites Sites { get; set; }
        }

        public class Sites
        {
            [JsonPropertyName("count")]
            public int Count { get; set; }

            [JsonPropertyName("site")]
            public List<Site> Site { get; set; }
        }

        public class Site
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("accountId")]
            public int AccountId { get; set; }

            [JsonPropertyName("status")]
            public string Status { get; set; }

            [JsonPropertyName("peakPower")]
            public double PeakPower { get; set; }

            [JsonPropertyName("lastUpdateTime")]
            public string LastUpdateTime { get; set; }

            [JsonPropertyName("installationDate")]
            public string InstallationDate { get; set; }

            [JsonPropertyName("ptoDate")]
            public string PtoDate { get; set; }

            [JsonPropertyName("notes")]
            public string Notes { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("location")]
            public Location Location { get; set; }

            [JsonPropertyName("primaryModule")]
            public PrimaryModule PrimaryModule { get; set; }

            [JsonPropertyName("uris")]
            public Uris Uris { get; set; }

            [JsonPropertyName("publicSettings")]
            public PublicSettings PublicSettings { get; set; }
        }

        public class Location
        {
            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("address")]
            public string Address { get; set; }

            [JsonPropertyName("zip")]
            public string Zip { get; set; }

            [JsonPropertyName("timeZone")]
            public string TimeZone { get; set; }

            [JsonPropertyName("countryCode")]
            public string CountryCode { get; set; }
        }

        public class PrimaryModule
        {
            [JsonPropertyName("manufacturerName")]
            public string ManufacturerName { get; set; }

            [JsonPropertyName("modelName")]
            public string ModelName { get; set; }

            [JsonPropertyName("maximumPower")]
            public double MaximumPower { get; set; }

            [JsonPropertyName("temperatureCoef")]
            public double TemperatureCoef { get; set; }
        }

        public class Uris
        {
            [JsonPropertyName("SITE_IMAGE")]
            public string SiteImage { get; set; }

            [JsonPropertyName("DATA_PERIOD")]
            public string DataPeriod { get; set; }

            [JsonPropertyName("DETAILS")]
            public string Details { get; set; }

            [JsonPropertyName("OVERVIEW")]
            public string Overview { get; set; }
        }

        public class PublicSettings
        {
            [JsonPropertyName("isPublic")]
            public bool IsPublic { get; set; }
        }
    }
}
