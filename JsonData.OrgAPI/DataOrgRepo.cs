using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace JsonData.OrgAPI
{
    class DataOrgRepo
    {
        string connectionString= "Server=LAPTOP-56JBDJD6;Database=Covid19ApiDB;User ID=hello;Password=world";
        private IDbConnection conn { get; set; }
        public DataOrgRepo()
        {
            conn = new SqlConnection(connectionString);
        }
        public void AddTimeSeries(CasesTimeSeries casesTimeSeries)
        {
            conn.Execute("AddTimeSeries", casesTimeSeries, commandType: CommandType.StoredProcedure);
        }
        public void AddStateWise(StateWise stateWise)
        {
            conn.Execute("AddStateWise", stateWise, commandType: CommandType.StoredProcedure);
        }
        public void AddTested(Tested tested)
        {
            conn.Execute("AddTested", tested, commandType: CommandType.StoredProcedure);
        }
    }
}
