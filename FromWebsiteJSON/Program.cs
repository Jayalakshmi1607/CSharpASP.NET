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
            /*DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(resp);
            DataTable travelHistories = dataSet.Tables["travel_history"];*/
            List<Covid19TravelHistory> travelHistories = JsonConvert.DeserializeObject<List<Covid19TravelHistory>>(resp);

            foreach (var traveller in travelHistories)
             {
                 travelHistory._cn6ca = traveller._cn6ca;
                 travelHistory.accuracylocation =traveller.accuracylocation;
                 travelHistory.address = traveller.address;
                 travelHistory.datasource = traveller.datasource;
                 travelHistory.latlong = traveller.latlong;
                 travelHistory.modeoftravel = traveller.modeoftravel;
                 travelHistory.pid =traveller.pid;
                 travelHistory.placename = traveller.placename;
                 travelHistory.timefrom = traveller.timefrom;
                 travelHistory.timeto =traveller.timeto;
                 travelHistory.type = traveller.type;
                 /*travelHistoryRepo.AddEmployee(travelHistory);*/
             }
        }
    }
}
