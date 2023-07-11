using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace logging.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggingController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] KeyValueRequest request)
        {
            Response.Headers.Add("my-response-header", "My response header");
            return Ok(request);
        }
    }

    public class KeyValueRequest
    {
        public Dictionary<string, string> Items { get; set; }
    }
}