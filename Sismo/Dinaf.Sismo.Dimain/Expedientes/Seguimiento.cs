using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Dimain.Expedientes
{
    public class Seguimiento
    {
        public int Id { get; set; }
        public int GidTipoCustodio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Referencias { get; set; }
        public int UsuarioRemitente { get; set; }
        public DateTime SFecha { get; set; }
        public string NumeroInstrumento { get; set; }
        public string ClaveTemporal { get; set; }
        public string TipoGestion { get; set; }
        public int IdNna { get; set; }
        public string IdCustodio { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string UnidadRemitente { get; set; }
        public string Coordinantes { get; set; }
    }
}
