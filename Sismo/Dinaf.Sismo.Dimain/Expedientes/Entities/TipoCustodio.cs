using System;

namespace Dinaf.Sismo.Domain.Expedientes.Entities
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
