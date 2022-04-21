using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public interface ISolicitudAdopcionService
    {
        public IList<SolicitudAdopcionDto> ObtenerSolicitudesAdopcion();
        public SolicitudAdopcionDto ObtenerSolicitudAdopcion(NumeroSolicitudDto numeroSolicitud);
        public void AgregarCaracteristicasAdopcion(CaracteristicasAdopcionDto caracteristicasAdopcion);
    }
}