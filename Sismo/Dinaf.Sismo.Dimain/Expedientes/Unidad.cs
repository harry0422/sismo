using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Dimain.Expedientes
{
    public class Unidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Centro Centro { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

        public IList<TipoGestion> TiposDeGestion { get; set; }

        public IList<Caso> Casos { get; set; }

    }
}