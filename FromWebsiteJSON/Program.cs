using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FromWebsiteJSON
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TravelHistory travelHistory = new TravelHistory();
            TravelHistoryRepo travelHistoryRepo = new TravelHistoryRepo();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("https://api.covid19india.org/travel_history.json");
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(resp);
            DataTable travelHistories = dataSet.Tables["travel_history"];
            foreach (DataRow traveller in travelHistories.Rows)
             {
                 travelHistory._cn6ca = (string)traveller["_cn6ca"];
                 travelHistory.accuracylocation =(string)traveller["accuracylocation"];
                 travelHistory.address = (string)traveller["address"];
                 travelHistory.datasource = (string)traveller["datasource"];
                 travelHistory.latlong = (string)traveller["latlong"];
                 travelHistory.modeoftravel = (string)traveller["modeoftravel"];
                 travelHistory.pid = (string)traveller["pid"];
                 travelHistory.placename = (string)traveller["placename"];
                 travelHistory.timefrom = (string)traveller["timefrom"];
                 travelHistory.timeto = (string)traveller["timeto"];
                 travelHistory.type = (string)traveller["type"];
                 travelHistoryRepo.AddEmployee(travelHistory);
             }
        }
    }
}
