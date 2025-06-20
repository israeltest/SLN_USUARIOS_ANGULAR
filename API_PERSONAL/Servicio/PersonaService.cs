using API_PERSONAL.Modelo;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace API_PERSONAL.Servicio
{
    public class PersonaService : IPersonaService
    {
        private readonly IConfiguration _config;
        public PersonaService(IConfiguration config)
        {
            _config = config;
        }

        private IDbConnection Connection => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        public async Task<IEnumerable<Persona>> ObtenerPersonasAsync()
        {
            using var conn = Connection;
            return await conn.QueryAsync<Persona>("sp_GetPersonas", commandType: CommandType.StoredProcedure);
        }

        public async Task<Persona?> ObtenerPorIdAsync(int id)
        {
            using var conn = Connection;
            return await conn.QueryFirstOrDefaultAsync<Persona>(
                "sp_GetPersonaById", new { Id = id }, commandType: CommandType.StoredProcedure);
        }

        public async Task CrearAsync(PersonaDto persona)
        {
            using var conn = Connection;
            await conn.ExecuteAsync("sp_CrearPersona", persona, commandType: CommandType.StoredProcedure);
        }

        public async Task ActualizarAsync(Persona persona)
        {
            using var conn = Connection;
            await conn.ExecuteAsync("sp_ActualizarPersona", persona, commandType: CommandType.StoredProcedure);
        }

        public async Task EliminarAsync(int id)
        {
            using var conn = Connection;
            await conn.ExecuteAsync("sp_EliminarPersona", new { Id = id }, commandType: CommandType.StoredProcedure);
        }
    }
}
