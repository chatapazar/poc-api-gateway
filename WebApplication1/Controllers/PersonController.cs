using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/Person
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Person-1", "Person-2" };
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Format("Person-{0}",id.ToString());
        }

        [HttpGet("request/header")]
        public ActionResult GetRequestHeader()
        {
            return Ok(Request.Headers);
        }
    }
}
