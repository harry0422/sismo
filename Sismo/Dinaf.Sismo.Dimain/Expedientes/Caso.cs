using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Dimain.Expedientes
{
    public class Caso
    {
        public int Id { get; set; }
        public int UsuarioApertura { get; set; }
        public int GidUnidad { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public int GidTipoGestion { get; set; }
        public string NumeroInstrumento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int GidUnidadDestino { get; set; }
        public int UsuarioAsignado { get; set; }

        IList<TipoGestion> TiposDeGestion { get; set; }

}
}
