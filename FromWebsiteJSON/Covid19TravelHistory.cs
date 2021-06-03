using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromWebsiteJSON
{
    class Covid19TravelHistory
    {
        internal string _cn6ca;
        internal string accuracylocation;
        internal string address;
        internal string datasource;
        internal string latlong;
        internal string modeoftravel;
        internal string pid;
        internal string placename;
        internal string timefrom;
        internal string timeto;
        internal string type;

        public List<TravelHistory> travelHistoryList { get; set; }
    }
}
