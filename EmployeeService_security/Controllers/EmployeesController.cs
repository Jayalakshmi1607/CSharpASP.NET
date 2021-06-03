using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Dapper;

namespace EmployeeService.Controllers
{
    [System.Web.Http.RoutePrefix("api/Employees")]
    public class EmployeesController:ApiController
    {
        string connectionString = "Server=LAPTOP-56JBDJD6;Database=master; User ID=hello;Password=world";
        private IDbConnection conn { get; set; }
        public EmployeesController()
        {
            conn = new SqlConnection(connectionString);
        }
        Users user = new Users();
        Employees employee = new Employees();
        public bool Login(string username, string password)
        {
            string userName = this.conn.QuerySingle("SELECT UserName FROM Users WHERE UserName=@UserName", new { username }).toString();
            string passWord = this.conn.QuerySingle("SELECT Password FROM Users WHERE UserName=@UserName", new { username }).toString();
            return (username == userName && password == passWord);
        }
        [System.Web.Http.HttpGet, System.Web.Http.Route("")]
        [BasicAuthentication]
        public HttpResponseMessage Get(string gender="All")
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            switch(username)
            {
                case "male":
                    return Request.CreateResponse(HttpStatusCode.OK, this.conn.Query<Employees>("SELECT*FROM Employees WHERE Gender=@Gender"));
                case "female":
                    return Request.CreateResponse(HttpStatusCode.OK, this.conn.Query<Employees>("SELECT*FROM Employees WHERE Gender=@Gender"));
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Value for gender is INVALID");
            }

        }
    }
}