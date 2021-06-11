using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AttributeRouting.Controllers
{
    [RoutePrefix("api/AttributeRouting")]
    public class AttributeRoutingController:ApiController
    {
            static List<string> strings = new List<string>()
            {
            "value0","value1","value2"
            };
            [HttpGet, Route("GetAll")]
            public IEnumerable<string> Get()
            {
                return strings;
            }
            [HttpGet, Route("GetById/{id}")]
            public string Get(int id)
            {
                return strings[id];
            }
            [HttpPost, Route("AddValue")]
            public void Post([FromBody] string value)
            {
                strings.Add(value);
            }
            [HttpPut, Route("UpdateValue/{id}")]
            public void Put(int id, [FromBody] string value)
            {
                strings[id] = value;
            }
            [HttpDelete, Route("DeleteValue/{id}")]
            public void Delete(int id)
            {
                strings.RemoveAt(id);
            }
    }
}