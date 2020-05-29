using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using led_service_domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace led_service_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LedController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(int red, int green, int blue)
        {
            var ledService = new LedService();
            ledService.SetColour(red, green, blue);
            return Ok();
        }
    }
}