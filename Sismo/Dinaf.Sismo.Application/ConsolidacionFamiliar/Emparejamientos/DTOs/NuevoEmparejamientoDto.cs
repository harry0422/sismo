using Microsoft.AspNetCore.Http;
using System;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs
{
    public class NuevoEmparejamientoDto
    {
        public string ExpedienteNna { get; set; }
        public string SolicitudAdopcion { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }

        //TODO: Create new view model and map to dto, add saving file logic in service method 
        public IFormFile Adjunto { get; set; }
    }
}