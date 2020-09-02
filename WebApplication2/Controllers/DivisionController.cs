using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        // GET: api/Division
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Division-1", "Division-2" };
        }

        // GET: api/Division/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Format("Division-{0}", id.ToString());
        }

        [HttpGet("request/header")]
        public ActionResult GetRequestHeader()
        {
            return Ok(Request.Headers);
        }
    }
}
