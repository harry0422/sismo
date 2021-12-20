using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Application.Seguimientos.DTOs
{
    public class SeguimientoDto
    {
        public int Id { get; set; }
        public string NumeroExpediente { get; set; }
        public string TipoCustodio { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Referencias { get; set; }
        public int UsuarioRemitente { get; set; }
        public string TipoGestion { get; set; }
        public string Estado { get; set; }
        public string UnidadRemitente { get; set; }
    }
}