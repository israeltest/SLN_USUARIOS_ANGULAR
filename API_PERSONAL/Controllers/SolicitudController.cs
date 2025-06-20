using API_PERSONAL.Modelo;
using API_PERSONAL.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace API_PERSONAL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SolicitudController : ControllerBase
    {
        private readonly ISolicitudService _service;
        public SolicitudController(ISolicitudService service) { _service = service; }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ObtenerSolicitudes());

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] SolicitudDto dto)
        {
            await _service.CrearAsync(dto);
            return Ok();
        }
    }
}
