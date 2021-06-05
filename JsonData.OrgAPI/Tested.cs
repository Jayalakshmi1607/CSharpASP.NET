using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonData.OrgAPI
{
    public class Tested
    {
        public string dailyrtpcrsamplescollectedicmrapplication { get; set; }
        public string firstdoseadministered { get; set; }
        public string frontlineworkersvaccinated1stdose { get; set; }
        public string frontlineworkersvaccinated2nddose { get; set; }
        public string healthcareworkersvaccinated1stdose { get; set; }
        public string healthcareworkersvaccinated2nddose { get; set; }
        public string over45years1stdose { get; set; }
        public string over45years2nddose { get; set; }
        public string over60years1stdose { get; set; }
        public string over60years2nddose { get; set; }
        public string positivecasesfromsamplesreported { get; set; }
        [JsonProperty("registration18-45years")]
        public string registration18_45years {get; set; }
        public string registrationabove45years { get; set; }
        public string registrationflwhcw { get; set; }
        public string registrationonline { get; set; }
        public string registrationonspot { get; set; }
        public string samplereportedtoday { get; set; }
        public string seconddoseadministered { get; set; }
        public string source { get; set; }
        public string source2 { get; set; }
        public string source3 { get; set; }
        public string source4 { get; set; }
        public string testedasof { get; set; }
        public string testsconductedbyprivatelabs { get; set; }
        [JsonProperty("to60yearswithco-morbidities1stdose")]
        public string to60yearswithco_morbidities1stdose { get; set; }
        [JsonProperty("to60yearswithco-morbidities2nddose")]
        public string to60yearswithco_morbidities2nddose { get; set; }
        public string totaldosesadministered { get; set; }
        public string totalindividualsregistered { get; set; }
        public string totalindividualstested { get; set; }
        public string totalindividualsvaccinated { get; set; }
        public string totalpositivecases { get; set; }
        public string totalrtpcrsamplescollectedicmrapplication { get; set; }
        public string totalsamplestested { get; set; }
        public string totalsessionsconducted { get; set; }
        public string updatetimestamp { get; set; }
        public string years1stdose { get; set; }
        public string years2nddose { get; set; }

    }
}
