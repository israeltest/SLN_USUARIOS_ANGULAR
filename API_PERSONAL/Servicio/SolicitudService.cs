using API_PERSONAL.Modelo;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace API_PERSONAL.Servicio
{
    public class SolicitudService : ISolicitudService
    {
        private readonly IConfiguration _config;
        public SolicitudService(IConfiguration config)
        {
            _config = config;
        }

        private IDbConnection Connection => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        public async Task<IEnumerable<Solicitud>> ObtenerSolicitudes()
        {
            using var conn = Connection;
            return await conn.QueryAsync<Solicitud>(
                "sp_GetSolicitudes", commandType: CommandType.StoredProcedure);
        }

        public async Task CrearAsync(SolicitudDto dto)
        {
            using var conn = Connection;
            await conn.ExecuteAsync("sp_CrearSolicitud", dto, commandType: CommandType.StoredProcedure);
        }
    }
}
