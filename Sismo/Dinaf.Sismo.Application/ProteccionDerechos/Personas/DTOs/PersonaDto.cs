namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public string NombreCorto { get; set; }
        public string NombreCompleto { get; set; }
        public string Ocupacion { get; set; }
        public string FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string TipoParentesco { get; set; }
    }
}
