using Microsoft.AspNetCore.Mvc;
using SLN_USUARIOS_ANGULAR.Repositorio;

namespace SLN_USUARIOS_ANGULAR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Insertar([FromBody] UsuarioDTO usuario)
        {
            await _repository.InsertarUsuarioAsync(usuario);
            return Ok(new { mensaje = "Usuario insertado con éxito" });
        }
    }
}
