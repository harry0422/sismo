using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Domain.Expedientes.Entities
{
    public class ExpedienteVulneracion
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioRemitente { get; set; }
        public string NumeroInstrumento { get; set; }
        public int TipoVulneracion { get; set; }
    }
}
