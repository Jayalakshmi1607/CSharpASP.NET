using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace JsonData.OrgAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            CasesTimeSeries casesTimeSeries = new CasesTimeSeries();
            StateWise stateWiseObj = new StateWise();
            DataOrgRepo dataOrgRepoObj = new DataOrgRepo();
            Tested testedObj = new Tested();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("https://api.covid19india.org/data.json").Result;
            var resp = response.Content.ReadAsStringAsync().Result;
            Covid19DataOrg dataOrg = JsonConvert.DeserializeObject<Covid19DataOrg>(resp);
            foreach(var jsonDataOrg in dataOrg.timeSeries)
            {
                casesTimeSeries.dailyconfirmed = jsonDataOrg.dailyconfirmed;
                casesTimeSeries.dailydeceased = jsonDataOrg.dailydeceased;
                casesTimeSeries.dailyrecovered = jsonDataOrg.dailyrecovered;
                casesTimeSeries.date = jsonDataOrg.date;
                casesTimeSeries.dateymd = jsonDataOrg.dateymd;
                casesTimeSeries.totalconfirmed = jsonDataOrg.totalconfirmed;
                casesTimeSeries.totaldeceased = jsonDataOrg.totaldeceased;
                casesTimeSeries.totalrecovered = jsonDataOrg.totalrecovered;
                dataOrgRepoObj.AddTimeSeries(casesTimeSeries);
            }
            foreach(var jsonStateOrg in dataOrg.stateWise)
            {
                stateWiseObj.active = jsonStateOrg.active;
                stateWiseObj.confirmed = jsonStateOrg.confirmed;
                stateWiseObj.deaths = jsonStateOrg.deaths;
                stateWiseObj.deltaconfirmed = jsonStateOrg.deltaconfirmed;
                stateWiseObj.deltadeaths = jsonStateOrg.deltadeaths;
                stateWiseObj.deltarecovered = jsonStateOrg.deltarecovered;
                stateWiseObj.lastupdatedtime = jsonStateOrg.lastupdatedtime;
                stateWiseObj.migratedother = jsonStateOrg.migratedother;
                stateWiseObj.recovered = jsonStateOrg.recovered;
                stateWiseObj.state = jsonStateOrg.state;
                stateWiseObj.statecode = jsonStateOrg.statecode;
                stateWiseObj.statenotes = jsonStateOrg.statenotes;
                dataOrgRepoObj.AddStateWise(stateWiseObj);

            }
            /*foreach(var jsonTestedOrg in dataOrg.tested)
            {
                testedObj.dailyrtpcrsamplescollectedicmrapplication =
                    jsonTestedOrg.dailyrtpcrsamplescollectedicmrapplication;
                testedObj.firstdoseadministered = jsonTestedOrg.firstdoseadministered;
                testedObj.frontlineworkersvaccinated1stdose = jsonTestedOrg.frontlineworkersvaccinated1stdose;
                testedObj.frontlineworkersvaccinated2nddose = jsonTestedOrg.frontlineworkersvaccinated2nddose;
                testedObj.healthcareworkersvaccinated1stdose = jsonTestedOrg.healthcareworkersvaccinated1stdose;
                testedObj.healthcareworkersvaccinated2nddose = jsonTestedOrg.healthcareworkersvaccinated2nddose;
                testedObj.over45years1stdose = jsonTestedOrg.over45years1stdose;
                testedObj.over45years2nddose = jsonTestedOrg.over45years2nddose;
                testedObj.over60years1stdose = jsonTestedOrg.over60years1stdose;
                testedObj.over60years2nddose = jsonTestedOrg.over60years2nddose;
                testedObj.positivecasesfromsamplesreported = jsonTestedOrg.positivecasesfromsamplesreported;
                testedObj.registration18_45years = jsonTestedOrg.registration18_45years;
                testedObj.registrationabove45years = jsonTestedOrg.registrationabove45years;
                testedObj.registrationflwhcw = jsonTestedOrg.registrationflwhcw;
                testedObj.registrationonline = jsonTestedOrg.registrationonline;
                testedObj.registrationonspot = jsonTestedOrg.registrationonspot;
                testedObj.samplereportedtoday = jsonTestedOrg.samplereportedtoday;
                testedObj.seconddoseadministered = jsonTestedOrg.seconddoseadministered;
                testedObj.source = jsonTestedOrg.source;
                testedObj.source2 = jsonTestedOrg.source2;
                testedObj.source3 = jsonTestedOrg.source3;
                testedObj.source4 = jsonTestedOrg.source4;
                testedObj.testedasof = jsonTestedOrg.testedasof;
                testedObj.testsconductedbyprivatelabs = jsonTestedOrg.testsconductedbyprivatelabs;
                testedObj.to60yearswithco_morbidities1stdose = jsonTestedOrg.to60yearswithco_morbidities1stdose;
                testedObj.to60yearswithco_morbidities2nddose = jsonTestedOrg.to60yearswithco_morbidities2nddose;
                testedObj.totaldosesadministered = jsonTestedOrg.totaldosesadministered;
                testedObj.totalindividualsregistered = jsonTestedOrg.totalindividualsregistered;
                testedObj.totalindividualstested = jsonTestedOrg.totalindividualstested;
                testedObj.totalindividualsvaccinated = jsonTestedOrg.totalindividualsvaccinated;
                testedObj.totalpositivecases = jsonTestedOrg.totalpositivecases;
                testedObj.totalrtpcrsamplescollectedicmrapplication =
                    jsonTestedOrg.totalrtpcrsamplescollectedicmrapplication;
                testedObj.totalsamplestested = jsonTestedOrg.totalsamplestested;
                testedObj.totalsessionsconducted = jsonTestedOrg.totalsessionsconducted;
                testedObj.updatetimestamp = jsonTestedOrg.updatetimestamp;
                testedObj.years1stdose = jsonTestedOrg.years1stdose;
                testedObj.years2nddose = jsonTestedOrg.years2nddose;
            }*/

        }
    }
}
