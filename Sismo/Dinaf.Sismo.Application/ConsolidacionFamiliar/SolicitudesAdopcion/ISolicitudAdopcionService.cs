using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public interface ISolicitudAdopcionService
    {
        public List<SolicitudAdopcionDto> GetSolicitudesAdopcion();
        public SolicitudAdopcionDto GetSolicitudAdopcion(NumeroExpedienteDto numeroExpediente);
        public void AddCaracteristicasAdopcion(CaracteristicasAdopcionDto caracteristicasAdopcion);
    }
}