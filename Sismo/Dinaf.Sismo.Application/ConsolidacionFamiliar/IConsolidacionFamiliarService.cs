using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public interface IConsolidacionFamiliarService
    {
        public List<SolicitudDeAdopcionDto> GetSolicitudesAdopcion();
        public List<NnaEstadoAdoptabilidadDto> GetNnaEstadoAdoptabilidad();
        public void AddCaracteristicasAdopcion(CaracteristicasAdopcionDto caracteristicasAdopcion);
        public void GetAdultosParaPosiblesEmparejamientos(NumeroExpedienteDto numeroExpediente);
        public void GetNiñosParaPosiblesEmparejamientos(NumeroExpedienteDto numeroExpediente);
    }
}