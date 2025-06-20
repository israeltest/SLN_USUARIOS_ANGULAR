namespace API_PERSONAL.Modelo
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string EstadoCivil { get; set; } = string.Empty; // Soltero, Casado, Viudo
        public DateTime FechaNacimiento { get; set; }
    }
}
