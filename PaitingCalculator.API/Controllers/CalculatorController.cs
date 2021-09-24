using Microsoft.AspNetCore.Mvc;
using PaintingCalculator.Domain.Entities;
using System.Collections.Generic;

namespace PaitingCalculator.API.Controllers
{
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [Route("calculate")]
        [HttpPost]
        public void Post([FromBody] List<Wall> wallList)
        {

        }
    }
}
