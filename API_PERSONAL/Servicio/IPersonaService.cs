using API_PERSONAL.Modelo;

namespace API_PERSONAL.Servicio
{
    public interface IPersonaService
    {
        Task<IEnumerable<Persona>> ObtenerPersonasAsync();
        Task<Persona?> ObtenerPorIdAsync(int id);
        Task CrearAsync(PersonaDto persona);
        Task ActualizarAsync(Persona persona);
        Task EliminarAsync(int id);
    }
}