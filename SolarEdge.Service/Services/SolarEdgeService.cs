using SolarEdge.Service.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using SolarEdge.Service.Models.SolarEdge.Service.Models.SiteListModels;
using SolarEdge.Service.Models.DataPeriodModels;
using System.Collections.Generic;
using System.Linq;
using SolarEdge.Service.Models.SolarEdgeOverviewData;
using SolarEdge.Service.Models.SolarEdgeEnergyDetails;
using SolarEdge.Service.Models.CurrentPowerFlowModels;
using SolarEdge.Service.Models.SolarEdgeStorageData;
using SolarEdge.Service.Models.SolarEdgeEnvBenefits;
using System.Security.Policy;
using SolarEdge.Service.Models.EquipmentModels;
using SolarEdge.Service.Models.InventoryModels;
using System.Runtime.InteropServices.ComTypes;
using SolarEdge.Service.Models.SolarEdgeMeterEnergyDetails;

namespace SolarEdge.Service.Services
{
    public class SolarEdgeService
    {
        private static string _ApiShortDateFormat = "yyyy-MM-dd";
        private static string _ApiDateWithTimeFormat = "yyyy-MM-dd HH:mm:ss";
        private readonly HttpClient _httpClient;
        private readonly SolarEdgeSettings _settings;

        public SolarEdgeService(SolarEdgeSettings settings)
        {
            _settings = settings;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_settings.BaseUrl)
            };
        }

        /// <summary>
        /// Get sites list
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeSiteList> GetSiteListAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
                { "size", "50" },
                { "sortProperty", "name" },
                { "sortOrder", "ASC" },

            };

            return await FetchDataAsync<SolarEdgeSiteList>($"/sites/list", queryParams);
        }

        /// <summary>
        /// Get site details
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeSiteDetails> GetSiteDetailsAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
            };

            return await FetchDataAsync<SolarEdgeSiteDetails>($"site/{_settings.SiteId}/details", queryParams);
        }

        /// <summary>
        /// Get site data period
        /// </summary>
        public async Task<SolarEdgeDataPeriod> GetSiteDataPeriodAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
            };

            return await FetchDataAsync<SolarEdgeDataPeriod>($"site/{_settings.SiteId}/dataPeriod", queryParams);
        }

        /// <summary>
        /// Get site energy
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeEnergyData> GetSiteEnergyAsync(DateTime startDate, DateTime endDate)
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
                { "timeUnit", "DAY" },
                { "startDate",  startDate.ToString(_ApiShortDateFormat) },
                { "endDate",  endDate.ToString(_ApiShortDateFormat) }
            };

            return await FetchDataAsync<SolarEdgeEnergyData>($"site/{_settings.SiteId}/energy", queryParams);
        }

        /// <summary>
        /// Get site power
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgePowerData> GetSitePowerDetailsAsync(DateTime startDate, DateTime endDate)
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
                { "startTime",  startDate.ToString(_ApiDateWithTimeFormat) },
                { "endTime",  endDate.ToString(_ApiDateWithTimeFormat) }
            };

            return await FetchDataAsync<SolarEdgePowerData>($"site/{_settings.SiteId}/power", queryParams);
        }

        /// <summary>
        /// Get site overview
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeOverviewData> GetSiteOverviewAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
            };

            return await FetchDataAsync<SolarEdgeOverviewData>($"site/{_settings.SiteId}/overview", queryParams);
        }

        /// <summary>
        /// Get site power details
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeEnergyDetails> GetSiteEnergyDetailsAsync(DateTime startDate, DateTime endDate)
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
                { "timeUnit", "DAY" },
                { "startTime",  startDate.ToString(_ApiDateWithTimeFormat) },
                { "endTime",  endDate.ToString(_ApiDateWithTimeFormat) },
                { "meters",  "Production,Consumption,SelfConsumption,FeedIn,Purchased" }
            };
       
            return await FetchDataAsync<SolarEdgeEnergyDetails>($"site/{_settings.SiteId}/energyDetails", queryParams);
        }

        /// <summary>
        /// Get site power flow
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeCurrentPowerFlow> GetSitePowerFlowAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
            };

            return await FetchDataAsync<SolarEdgeCurrentPowerFlow>($"site/{_settings.SiteId}/currentPowerFlow", queryParams);
        }

        /// <summary>
        /// Get site power details
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeStorageData> GetStorageInformationAsync(DateTime startDate, DateTime endDate)
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
                { "startTime",  startDate.ToString(_ApiDateWithTimeFormat) },
                { "endTime",  endDate.ToString(_ApiDateWithTimeFormat) },
                { "serials",  "" }
            };

            return await FetchDataAsync<SolarEdgeStorageData>($"site/{_settings.SiteId}/storageData", queryParams);
        }

        /// <summary>
        /// Get site environmental benefits
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeEnvBenefits> GetSiteEnvironmentalBenefitsAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
                { "systemUnits", "Imperial" },
            };

            return await FetchDataAsync<SolarEdgeEnvBenefits>($"site/{_settings.SiteId}/envBenefits", queryParams);
        }

        /// <summary>
        /// Get equipment list
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeEquipmentList> GetEquipmentsListAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
            };

            return await FetchDataAsync<SolarEdgeEquipmentList>($"equipment/{_settings.SiteId}/list", queryParams);
        }

        /// <summary>
        /// Get site invertory
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeInventory> GetInvertoryAsync()
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
            };

            return await FetchDataAsync<SolarEdgeInventory>($"site/{_settings.SiteId}/inventory", queryParams);
        }

        /// <summary>
        /// Get meters data
        /// </summary>
        /// <returns></returns>
        public async Task<SolarEdgeMeterEnergyDetails> GetMetersDataAsync(DateTime startDate, DateTime endDate)
        {
            var queryParams = new Dictionary<string, string> {
                { "api_key", _settings.ApiKey },
                { "startTime",  startDate.ToString(_ApiDateWithTimeFormat) },
                { "endTime",  endDate.ToString(_ApiDateWithTimeFormat) },
                { "meters",  "Production,Consumption,SelfConsumption,FeedIn,Purchased" }
            };

            return await FetchDataAsync<SolarEdgeMeterEnergyDetails>($"site/{_settings.SiteId}/meters", queryParams);
        }

        /// <summary>
        /// Generic method to fetch data from API
        /// </summary>
        private async Task<T> FetchDataAsync<T>(string endpoint, Dictionary<string, string> queryParams = null)
        {
            if (queryParams != null && queryParams.Count > 0)
            {
                var encodedParams = string.Join("&", queryParams.Select(kvp =>
                    $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));
                endpoint = $"{endpoint}?{encodedParams}";
            }

            var response = await _httpClient.GetAsync(endpoint);
            if (!response.IsSuccessStatusCode)
                throw new Exception($"API error: {response.StatusCode}");

            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<T>(json, options);
        }

    }
}

