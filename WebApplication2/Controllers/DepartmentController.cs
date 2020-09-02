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
    public class DepartmentController : ControllerBase
    {
        // GET: api/Department
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Department-1", "Department-2" };
        }

        // GET: api/Department/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Format("Department-{0}", id.ToString());
        }

        [HttpGet("request/header")]
        public ActionResult GetRequestHeader()
        {
            return Ok(Request.Headers);
        }
    }
}
