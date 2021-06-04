using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonData.OrgAPI
{
    public class Covid19DataOrg
    {
        [JsonProperty("cases_time_series")]
        public CasesTimeSeries[] timeSeries {get; set;}
        [JsonProperty("statewise")]
        public StateWise[] stateWise { get; set; }
        [JsonProperty("tested")]
        public Tested[] tested { get; set; }
    }
}
