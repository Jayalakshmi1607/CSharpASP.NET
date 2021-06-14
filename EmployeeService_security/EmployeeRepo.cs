using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeService
{
    public class EmployeeRepo
    {
        string connectionString = "Server=LAPTOP-56JBDJD6;Database=EmployeeDB; User ID=hello;Password=world";
        public IDbConnection conn { get; set; }
        public EmployeeRepo()
        {
            conn = new SqlConnection(connectionString);
        }
        public string UserName(string username)
        {
            return conn.QueryFirst<string>("SELECT UserName FROM Users WHERE UserName=@UserName", new { username });
        }
        public string Password(string username)
        {
            return conn.QueryFirst<string>("SELECT Password FROM Users WHERE UserName=@UserName", new { username });
        }
       
    }
}