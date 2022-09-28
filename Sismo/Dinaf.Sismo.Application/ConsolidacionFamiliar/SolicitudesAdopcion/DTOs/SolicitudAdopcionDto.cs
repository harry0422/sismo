using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs
{
    public class SolicitudAdopcionDto
    {
        public string NumeroExpediente { get; set; }
        public string Nombres { get; set; }
        public string FechaCreacion { get; set; }
        public string TipoInstrumento { get; set; }
        public string Estado { get; set; }
        public string TipoSolicitud { get; set; }
        public string Procedencia { get; set; }
        public string MotivoAdopcion { get; set; }
        public string RepresentanteLegal { get; set; }
        public CaracteristicasAdopcionDto CaracteristicasAdopcionActual { get; set; }
        public IList<SolicitanteDto> Solicitantes { get; set; }
        public IList<CaracteristicasAdopcionDto> HistoricoDeBusquedas { get; set; }
    }
}