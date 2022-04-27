namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs
{
    public class SolicitanteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Genero { get; set; }
        public string Estado { get; set; }
        public int Edad { get; set; }
        public string FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Ocupacion { get; set; }
        public string FotoPerfil { get; set; }
    }
}