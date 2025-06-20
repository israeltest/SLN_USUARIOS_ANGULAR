using API_PERSONAL.Modelo;
using API_PERSONAL.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace API_PERSONAL.Controllers
{
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _service;

        public PersonaController(IPersonaService service)
        {
            _service = service;
        }

        [HttpGet("ObtenerPersona")]
        public async Task<IActionResult> ObtenerPersona() => Ok(await _service.ObtenerPersonasAsync());

        [HttpGet("ObtenerPersonaID/{id}")]
        public async Task<IActionResult> ObtenerPersonaID(int id) => Ok(await _service.ObtenerPorIdAsync(id));

        [HttpPost("CrearPersona")]
        public async Task<IActionResult>CrearPersona([FromBody] PersonaDto persona)
        {
            await _service.CrearAsync(persona);
            return Ok();
        }

        [HttpPut("ActualizarPersona")]
        public async Task<IActionResult> ActualizarPersona([FromBody] Persona persona)
        {
            await _service.ActualizarAsync(persona);
            return Ok();
        }

        [HttpDelete("DeletePersona/{id}")]
        public async Task<IActionResult> DeletePersona(int id)
        {
            await _service.EliminarAsync(id);
            return Ok();
        }
    }
}
