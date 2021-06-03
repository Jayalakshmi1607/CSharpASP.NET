using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace StepCSharpWebAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/webapirouting")]
    public class WebAPIRoutingController : ApiController
    {
        static List<string> languages = new List<string>()
        {
            "C#","ASP.NET","JAVA"
        };
        [System.Web.Http.Route("getLanguages")]
        [System.Web.Http.HttpGet]
        public IEnumerable<string> GetLanguage()
        {
            return languages;
        }
        [System.Web.Http.Route("getLanguage/{id}")]
        [System.Web.Http.HttpGet]
        public string GetLanguage(int id)
        {
            return languages[id];
        }
        [System.Web.Http.Route("saveLanguage")]
        [System.Web.Http.HttpPost]
        public void SaveLanguage([FromBody] string value)
        {
            languages.Add(value);
        }
        [System.Web.Http.Route("updateLanguage/{id}")]
        [System.Web.Http.HttpPut]
        public void UpdateLanguage(int id, [FromBody] string value)
        {
            languages[id] = value;
        }
        [System.Web.Http.Route("deleteLanguage/{id}")]
        [System.Web.Http.HttpDelete]
        public void DeleteLanguage(int id)
        {
            languages.RemoveAt(id);
        }
    }
}