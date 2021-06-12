using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AttributeRouting
{
    public class TravelHistoryRepo
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
        public List<TravelHistory> GetTravelHistory()
        {
            
            List<TravelHistory> list=this.conn.Query<TravelHistory>("SELECT*FROM TravelHistory").ToList();
            return list;
        }
        public List<TravelHistory> GetTraveller(TravelHistory travelHistory)
        {
           return this.conn.Query<TravelHistory>("SELECT*FROM TravelHistory WHERE _cn6ca=@_cn6ca", travelHistory).ToList();
        }

        public void UpdateTraveller(TravelHistory travelHistory)
        {
            conn.Execute("UpdateTraveller", travelHistory,commandType:CommandType.StoredProcedure);
        }

        public void DeleteTraveller(TravelHistory travelHistory)
        {
            conn.Execute("DELETE FROM TravelHistory WHERE _cn6ca=@_cn6ca", travelHistory);
        }
    }
}