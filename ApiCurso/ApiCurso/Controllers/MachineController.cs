using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiCurso.Controllers
{
    [Route("api/[controller]")]
    public class MachineController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult GetMachine()
        {
            return Ok(new { nome = Environment.MachineName,data = DateTime.UtcNow});
        }
    }
}
