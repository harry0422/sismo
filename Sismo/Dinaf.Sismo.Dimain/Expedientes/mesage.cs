using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Dimain.Expedientes
{
    public class mesage
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaLeido { get; set; }
        public int UsuarioRemitente { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public int GidCaso { get; set; }
        public string Tipo { get; set; }
        public string UnidadDestino { get; set; }
        public string UnidadRemitente { get; set; }
        public string ClaveTemporal { get; set; }
    }
}
