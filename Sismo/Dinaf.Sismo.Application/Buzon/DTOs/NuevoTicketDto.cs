namespace Dinaf.Sismo.Application.Buzon.DTOs
{
    public class NuevoTicketDto
    {
        public int UsuarioApertura { get; set; }
        public int UsuarioAsignado { get; set; }
        public int TipoGestion { get; set; }
        public string NumeroInstrumento { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
    }
}