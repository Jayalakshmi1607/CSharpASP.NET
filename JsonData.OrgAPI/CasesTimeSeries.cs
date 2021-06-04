using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonData.OrgAPI
{
    public class CasesTimeSeries
    {
        public int dailyconfirmed { get; set; }
        public int dailydeceased { get; set; }
        public int dailyrecovered { get; set; }
        public string date { get; set; }
        public string dateymd { get; set; }
        public int totalconfirmed { get; set; }
        public int totaldeceased { get; set; }
        public int totalrecovered { get; set; }

    }
}
