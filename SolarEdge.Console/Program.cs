using Skrotfrag.SfDataAccess;
using SolarEdge.Service.Models;
using SolarEdge.Service.Services;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace SolarEdge.Console
{
    internal class Program
    {
        private static SolarEdgeService _solarEdgeService;
        private static DataWorker _dataworker;
        private static string _cn = "Data Source=.\\sqldev;Initial Catalog=SfVagSQLUdd2410;Integrated Security=true;";

        static async Task Main(string[] args)
        {
            _solarEdgeService = new SolarEdgeService(new SolarEdgeSettings
            {
                ApiKey = "Y83YI1QIB0S1XDN15DPWFVIU1LPKJUAZ",
                BaseUrl = "https://monitoringapi.solaredge.com/",
                SiteId = "4110825"
            });

            _cn = ConfigurationManager.ConnectionStrings["SolarEdge.Console.Properties.Settings.db"].ConnectionString;

            await GetSiteDetailsAsync(); //

            //await GetSiteEnergyAsync();
            //await GetSiteDataPeriodAsync();
            //await GetSiteListAsync();
            //await GetSitePowerDetailsAsync();
            await GetSiteEnergyDetailsAsync(); //
            //await GetSitePowerFlowAsync();
            //await GetStorageInformationAsync();
            //await GetSiteEnvironmentalBenefitsAsync();
            //await GetEquipmentsListAsync();
            //await GetInvertoryAsync();
            //await GetMetersDataAsync();

        }

        public static async Task GetSiteDetailsAsync()
        {
          
            var result = await _solarEdgeService.GetSiteDetailsAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = false
            });
            using (SqlConnection conn = new SqlConnection(_cn))
            {
                conn.Open();

                string query = "INSERT INTO SolarData (Site, [Interface], RawJson) VALUES (@site, @interface, @json)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@site", 1);
                    cmd.Parameters.AddWithValue("@interface", "SiteDetails");
                    cmd.Parameters.AddWithValue("@json", json);
                    cmd.ExecuteNonQuery();
                }

                               
            }
        }

        public static async Task GetSiteListAsync()
        {
            var result = await _solarEdgeService.GetSiteListAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetSiteDataPeriodAsync()
        {
            var result = await _solarEdgeService.GetSiteDataPeriodAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetSiteEnergyAsync()
        {
            var result = await _solarEdgeService.GetSiteEnergyAsync(new DateTime(2025, 3, 24), new DateTime(2025, 3, 24));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetSitePowerDetailsAsync()
        {
            var result = await _solarEdgeService.GetSitePowerDetailsAsync(new DateTime(2025, 3, 24), new DateTime(2025, 3, 24));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetSiteEnergyDetailsAsync()
        {
            var result = await _solarEdgeService.GetSiteEnergyDetailsAsync(new DateTime(2025, 3, 24), new DateTime(2025, 3, 24));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = false
            });
            using (SqlConnection conn = new SqlConnection(_cn))
            {
                conn.Open();

                string query = "INSERT INTO SolarData (Site, [Interface], RawJson) VALUES (@site, @interface, @json)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@site", 1);
                    cmd.Parameters.AddWithValue("@interface", "EnergyDetails");
                    cmd.Parameters.AddWithValue("@json", json);
                    cmd.ExecuteNonQuery();
                }


            }
            /* Debugger.Break(); */
            System.Console.WriteLine(json);
        }

        public static async Task GetSitePowerFlowAsync()
        {
            var result = await _solarEdgeService.GetSitePowerFlowAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = false
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetStorageInformationAsync()
        {
            var result = await _solarEdgeService.GetStorageInformationAsync(new DateTime(2025, 3, 24), new DateTime(2025, 3, 24));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetSiteEnvironmentalBenefitsAsync()
        {
            var result = await _solarEdgeService.GetSiteEnvironmentalBenefitsAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetEquipmentsListAsync()
        {
            var result = await _solarEdgeService.GetEquipmentsListAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetInvertoryAsync()
        {
            var result = await _solarEdgeService.GetInvertoryAsync();

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            /* Debugger.Break(); */ System.Console.WriteLine(json);
        }

        public static async Task GetMetersDataAsync()
        {
            var result = await _solarEdgeService.GetMetersDataAsync(new DateTime(2025, 2, 01), new DateTime(2025, 2, 27));

            var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            MethodInfo method = typeof(SolarEdgeService).GetMethod("GetMetersDataAsync", BindingFlags.NonPublic | BindingFlags.Instance);
            /* Debugger.Break(); */
            System.Console.WriteLine(json);
        }
    }
}
