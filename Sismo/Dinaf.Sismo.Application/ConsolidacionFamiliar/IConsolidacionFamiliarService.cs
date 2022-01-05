using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public interface IConsolidacionFamiliarService
    {
        public List<SolicitudAdopcionDto> GetSolicitudesAdopcion();
        public SolicitudAdopcionDto GetSolicitudAdopcion(NumeroExpedienteDto numeroExpediente);
        public List<ExpedienteNnaDto> GetNnaEstadoAdoptabilidad();
        public ExpedienteNnaDto GetNnaEstadoAdoptabilidad(NumeroExpedienteDto numeroExpediente);
    }
}