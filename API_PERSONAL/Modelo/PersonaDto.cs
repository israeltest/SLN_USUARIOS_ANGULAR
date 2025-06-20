namespace API_PERSONAL.Modelo
{
    public class PersonaDto
    {
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string EstadoCivil { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
    }
}
