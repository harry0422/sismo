using System;

namespace Dinaf.Sismo.Application.Vulneraciones.DTOs
{
    public class VulneracionDto
    {
        public int Id { get; set; }
        public string FechaCreacion { get; set; }
        public int UsuarioRemitente { get; set; }
        public string NumeroInstrumento { get; set; }
        public string Articulo { get; set; }
        public string Tipoligia { get; set; }
    }
}