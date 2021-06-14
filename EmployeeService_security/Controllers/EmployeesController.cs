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
        
        Users user = new Users();
        EmployeeRepo employeeRepo = new EmployeeRepo();
        public bool Login(string username, string password)
        {
            string userName = employeeRepo.UserName(username);

            string passWord = employeeRepo.Password(username);
            return (username == userName && password == passWord);
        }
        [System.Web.Http.HttpGet, System.Web.Http.Route("")]
        [BasicAuthentication]
        public HttpResponseMessage Get()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            switch(username)
            {
               case "male":
                    return Request.CreateResponse(HttpStatusCode.OK, 
                        employeeRepo.conn.Query<Employees>("SELECT*FROM Employees WHERE Gender=@Gender",new {Gender=username}));
                case "female":
                    return Request.CreateResponse(HttpStatusCode.OK, 
                        employeeRepo.conn.Query<Employees>("SELECT*FROM Employees WHERE Gender=@Gender",new {Gender=username}));
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Value for gender is INVALID");
            }

        }
    }
}
