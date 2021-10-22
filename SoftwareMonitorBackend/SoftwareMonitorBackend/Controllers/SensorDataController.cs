using Microsoft.AspNetCore.Mvc;
using SoftwareMonitorBackend.Attributes;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SoftwareMonitorBackend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    //[RightElevation]
    public class SensorDataController : ControllerBase
    {
        /// <summary>
        /// Dient zur Übertragung von Sensordaten.
        /// 
        /// HeaderElement "SensorID" erforderlich!
        /// </summary>
        [HttpPost("{id}")]
        public IActionResult Post(int id, [FromBody] JsonElement value)
        {
            switch (id)
            {
                case 1:
                    //Sensor 1 Daten in die DB hauen
                    return Ok(id);
                default:
                    return BadRequest();
            }
        }
    }
}