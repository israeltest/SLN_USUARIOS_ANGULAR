using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace SLN_USUARIOS_ANGULAR.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public UsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task InsertarUsuarioAsync(UsuarioDTO usuario)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync(
                "sp_InsertarUsuario",
                new { usuario.Nombre, usuario.Correo },
                commandType: CommandType.StoredProcedure
            );
        }
    }
}
