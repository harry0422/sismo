using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Dimain.Expedientes
{
    public class TipoCustodio
    {
        public int GidTipoCustodio { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime SFecha { get; set; }
        public int Id { get; set; }
        public int Orden { get; set; }
    }
}
