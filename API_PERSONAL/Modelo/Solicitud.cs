namespace API_PERSONAL.Modelo
{
    public class Solicitud
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string? NombrePersona { get; set; } // para mostrar en el joined select
    }
}
