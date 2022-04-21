using System;

namespace Dinaf.Sismo.Application.Buzon.DTOs
{
    public class MensajeDto
    {
        public string FechaCreacion { get; set; }
        public int Remitente { get; set; }
        public int UnidadRemitente { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public int Caso { get; set; }
        public string Tipo { get; set; }
        public bool Leido { get; set; }
    }
}