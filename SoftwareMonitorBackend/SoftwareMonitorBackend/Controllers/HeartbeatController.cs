using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace SoftwareMonitorBackend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HeartbeatController : ControllerBase
    {
        [HttpPut]
        public IActionResult Put()
        {
            if (this.Request.Headers.TryGetValue("ApiKey", out var id))
            {
                //Update LastSeen in Customer table from DB

                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
