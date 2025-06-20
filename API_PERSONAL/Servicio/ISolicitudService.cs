using API_PERSONAL.Modelo;

namespace API_PERSONAL.Servicio
{
    public interface ISolicitudService
    {
        Task<IEnumerable<Solicitud>> ObtenerSolicitudes();
        Task CrearAsync(SolicitudDto dto);
    }
}