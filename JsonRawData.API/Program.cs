using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JsonRawData.API
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RawData rawDataObj = new RawData();
            RawDataRepo rawDataRepo = new RawDataRepo();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("https://api.covid19india.org/raw_data.json").Result;
            var resp = response.Content.ReadAsStringAsync().Result;
            Covid19RawData CovidRawDataObj = JsonConvert.DeserializeObject<Covid19RawData>(resp);
            foreach(var varRawData in CovidRawDataObj.rawData)
            {
                rawDataObj.agebracket = varRawData.agebracket;
                rawDataObj.backupnotes = varRawData.backupnotes;
                rawDataObj.contractedfromwhichpatientsuspected = varRawData.contractedfromwhichpatientsuspected;
                rawDataObj.currentstatus = varRawData.currentstatus;
                rawDataObj.dateannounced = varRawData.dateannounced;
                rawDataObj.detectedcity = varRawData.detectedcity;
                rawDataObj.detecteddistrict = varRawData.detecteddistrict;
                rawDataObj.detectedstate = varRawData.detectedstate;
                rawDataObj.estimatedonsetdate = varRawData.estimatedonsetdate;
                rawDataObj.gender = varRawData.gender;
                rawDataObj.nationality = varRawData.nationality;
                rawDataObj.notes = varRawData.notes;
                rawDataObj.numcases = varRawData.numcases;
                rawDataObj.patientnumber = varRawData.patientnumber;
                rawDataObj.source1 = varRawData.source1;
                rawDataObj.source2 = varRawData.source2;
                rawDataObj.source3 = varRawData.source3;
                rawDataObj.statecode = varRawData.statecode;
                rawDataObj.statepatientnumber = varRawData.statepatientnumber;
                rawDataObj.statuschangedate = varRawData.statuschangedate;
                rawDataObj.typeoftransmission = varRawData.typeoftransmission;
                rawDataRepo.AddRawData(rawDataObj);
            }
        }
    }
}
