using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace JsonRawData.API
{
    public class RawDataRepo
    {
        string connectionString = "Server=LAPTOP-56JBDJD6;Database=Covid19ApiDB;User ID=hello;Password=world";
        private IDbConnection conn { get; set; }
        public RawDataRepo()
        {
            conn = new SqlConnection(connectionString);
        }
        public void AddRawData(RawData rawData)
        {
            conn.Execute("AddRawData", rawData, commandType: CommandType.StoredProcedure);
        }
    }
}
