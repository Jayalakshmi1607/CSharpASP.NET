﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttributeRouting
{
    public class TravelHistory
    {
        public string _cn6ca { get; set; }
        public string accuracylocation { get; set; }
        public string address { get; set; }
        public string datasource { get; set; }
        public string latlong { get; set; }
        public string modeoftravel { get; set; }
        public string pid { get; set; }
        public string placename { get; set; }
        public string timefrom { get; set; }
        public string timeto { get; set; }
        public string type { get; set; }

        internal void AddTraveller(TravelHistory travelHistory)
        {
            throw new NotImplementedException();
        }
    }
}