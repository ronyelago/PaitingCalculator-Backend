using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PaitingCalculator.API.Controllers
{
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [Route("calculate")]
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
    }
}
