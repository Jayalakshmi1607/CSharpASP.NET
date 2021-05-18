using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StepCSharpWebAPI.Controllers
{
    public class WebAPIRouting
    {
        static List<string> languages = new List<string>()
        {
            "C#","ASP.NET","JAVA"
        };
        public IEnumerable<string> Get()
        {
            return languages;
        }
        public string Get(int id)
        {
            return languages[id];
        }
        public void Post([FromBody] string value)
        {
            languages.Add(value);
        }
    }
}