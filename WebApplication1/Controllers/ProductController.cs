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
    public class ProductController : ControllerBase
    {
        // GET: api/Product
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Product-1", "Product-2" };
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Format("Product-{0}", id.ToString());
        }

        [HttpGet("request/header")]
        public ActionResult GetRequestHeader()
        {
            return Ok(Request.Headers);
        }
    }
}
