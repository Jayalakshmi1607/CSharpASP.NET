using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonRawData.API
{
    public class Covid19RawData
    {
        [JsonProperty("raw_data")]
        public RawData[] rawData { get; set; }
    }
}
