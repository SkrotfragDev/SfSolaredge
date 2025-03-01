using SolarEdge.Service.Models;
using SolarEdge.Service.Services;
using System;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;

namespace SolarEdge.Console
{
    internal class Program
    {
        private static SolarEdgeService _solarEdgeService;

        static async Task Main(string[] args)
        {
            _solarEdgeService = new SolarEdgeService(new SolarEdgeSettings
            {
                ApiKey = "Y83YI1QIB0S1XDN15DPWFVIU1LPKJUAZ",
                BaseUrl = "https://monitoringapi.solaredge.com/",
                SiteId = "4110825"
            });

            //await GetSiteOverviewAsync();
            //await GetSiteDetailsAsync();
            //await GetSitePowerAsync();
            //await GetSiteEnergyAsync();
            //await GetSiteDataPeriodAsync();
            //await GetSiteListAsync();
            //await GetSitePowerDetailsAsync();
            //await GetSiteEnergyDetailsAsync();
            //await GetSitePowerFlowAsync();
            //await GetStorageInformationAsync();
            //await GetSiteEnvironmentalBenefitsAsync();
            //await GetEquipmentsListAsync();
            //await GetInvertoryAsync();
            await GetMetersDataAsync();

        }

        public static async Task GetSiteDetailsAsync()
        {
            var result = await _solarEdgeService.GetSiteDetailsAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetSiteListAsync()
        {
            var result = await _solarEdgeService.GetSiteListAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetSiteDataPeriodAsync()
        {
            var result = await _solarEdgeService.GetSiteDataPeriodAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetSiteEnergyAsync()
        {
            var result = await _solarEdgeService.GetSiteEnergyAsync(new DateTime(2025,2,24), new DateTime(2025, 2, 27));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetSitePowerDetailsAsync()
        {
            var result = await _solarEdgeService.GetSitePowerDetailsAsync(new DateTime(2025, 2, 24), new DateTime(2025, 2, 27));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetSiteEnergyDetailsAsync()
        {
            var result = await _solarEdgeService.GetSiteEnergyDetailsAsync(new DateTime(2025, 2, 24), new DateTime(2025, 2, 27));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetSitePowerFlowAsync()
        {
            var result = await _solarEdgeService.GetSitePowerFlowAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetStorageInformationAsync()
        {
            var result = await _solarEdgeService.GetStorageInformationAsync(new DateTime(2025, 2, 24), new DateTime(2025, 2, 27));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetSiteEnvironmentalBenefitsAsync()
        {
            var result = await _solarEdgeService.GetSiteEnvironmentalBenefitsAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetEquipmentsListAsync()
        {
            var result = await _solarEdgeService.GetEquipmentsListAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetInvertoryAsync()
        {
            var result = await _solarEdgeService.GetInvertoryAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }

        public static async Task GetMetersDataAsync()
        {
            var result = await _solarEdgeService.GetMetersDataAsync(new DateTime(2025, 2, 24), new DateTime(2025, 2, 27));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Debugger.Break();
        }
    }
}
