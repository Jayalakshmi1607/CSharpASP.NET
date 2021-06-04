using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonData.OrgAPI
{
    public class StateWise
    {
        public int active { get; set; }
        public int confirmed { get; set; }
        public int deaths { get; set; }
        public int deltaconfirmed { get; set; }
        public int deltadeaths { get; set; }
        public int deltarecovered { get; set; }
        public string lastupdatedtime { get; set; }
        public int migratedother { get; set; }
        public int recovered { get; set; }
        public string state { get; set; }
        public string statecode { get; set; }
        public string statenotes { get; set; }
    }
}
