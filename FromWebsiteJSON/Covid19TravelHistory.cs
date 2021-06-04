using Newtonsoft.Json;
using System.Collections.Generic;

namespace FromWebsiteJSON
{
    public class Covid19TravelHistory
    {
        [JsonProperty("travel_history")]
        public TravelHistory[] travel { get; set; }

    }
}