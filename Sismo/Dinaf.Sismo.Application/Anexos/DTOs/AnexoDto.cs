namespace Dinaf.Sismo.Application.Anexos.DTOs
{
    public class AnexoDto
    {
        public int Id { get; set; }
        public string FechaCreacion { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public string UsuarioRemitente { get; set; }
        public string NumeroExpediente { get; set; }
        public string Responsable { get; set; }
        public int UnidadRemitente { get; set; }
    }
}