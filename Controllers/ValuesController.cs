using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StepCSharpWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        static List<string> languages = new List<string>() {
            "C#","ASP.NET","MVC"
};
        public IEnumerable<string> Get()
        {
            return languages;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return languages[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
