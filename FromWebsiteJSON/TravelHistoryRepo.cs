using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace FromWebsiteJSON
{
    class TravelHistoryRepo
    {
        string connectionString = "Server=LAPTOP-56JBDJD6;Database=Covid19ApiDB;User ID=hello;Password=world";
        private IDbConnection conn { get; set; }
        public TravelHistoryRepo()
        {
            conn = new SqlConnection(connectionString);
        }
        public void AddTraveller(TravelHistory travelHistory)
        {
            conn.Execute("InsertData", travelHistory, commandType: CommandType.StoredProcedure);
        }
    }
}
