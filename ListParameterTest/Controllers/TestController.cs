using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListParameterTest.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Get([FromQuery]List<int> ids)
        {
            foreach (var item in ids)
            {
                Debug.WriteLine(item.ToString());
            }

            return Ok();
        }
    }
}