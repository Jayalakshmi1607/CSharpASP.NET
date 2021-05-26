using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net;
using System.Text;
using System.Threading;
using System.Security.Principal;
using EmployeeService.Controllers;

namespace EmployeeService
{
    public class BasicAuthenticationAttribute:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if(actionContext.Request.Headers.Authorization==null)
            {
                actionContext.Response = actionContext.Request.
                    CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.
                    Authorization.Parameter;
                string decodedAuthenticationToken=Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
                string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
                string username = usernamePasswordArray[0];
                string password = usernamePasswordArray[1];
                EmployeesController emp = new EmployeesController();
                if(emp.Login(username,password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.
                    CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}