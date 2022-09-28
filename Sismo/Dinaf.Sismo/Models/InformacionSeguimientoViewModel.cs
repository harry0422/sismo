using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Models
{
    public class InformacionSeguimientoViewModel
    {
        public string Id { get; set; }
        public string ExpedienteNna { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public IList<IFormFile> Adjunto { get; set; }
    }
}
