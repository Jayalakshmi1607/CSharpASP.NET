using System;
using System.Collections;
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
        public static async Task Main(string[] args)
        {
            TravelHistory travelHistory = new TravelHistory();
            TravelHistoryRepo travelHistoryRepo = new TravelHistoryRepo();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));



            HttpResponseMessage response = client.GetAsync("https://api.covid19india.org/travel_history.json").Result;
            //response.EnsureSuccessStatusCode();
            var resp = response.Content.ReadAsStringAsync().Result;
            /*DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(resp);
            DataTable travelHistories = dataSet.Tables["travel_history"];*/
            //Covid19TravelHistory covidDetails = new Covid19TravelHistory();
            //List<TravelHistory> travelHistoryTravel = new List<TravelHistory>();
            Covid19TravelHistory covidDetails = JsonConvert.DeserializeObject<Covid19TravelHistory>(resp);
            
            foreach (var traveller in covidDetails.travel)
            {
                travelHistory._cn6ca = traveller._cn6ca;
                travelHistory.accuracylocation = traveller.accuracylocation;
                travelHistory.address = traveller.address;
                travelHistory.datasource = traveller.datasource;
                travelHistory.latlong = traveller.latlong;
                travelHistory.modeoftravel = traveller.modeoftravel;
                travelHistory.pid = traveller.pid;
                travelHistory.placename = traveller.placename;
                travelHistory.timefrom = traveller.timefrom;
                travelHistory.timeto = traveller.timeto;
                travelHistory.type = traveller.type;
                travelHistoryRepo.AddEmployee(travelHistory);
            }
        }
    }
}