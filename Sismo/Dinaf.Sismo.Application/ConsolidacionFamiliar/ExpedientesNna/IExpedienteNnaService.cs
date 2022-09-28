using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public interface IExpedienteNnaService
    {
        public IList<ExpedienteNnaDto> GetNnaEstadoAdoptabilidad();
        public ExpedienteNnaDto GetNnaEstadoAdoptabilidad(NumeroExpedienteNnaDto numeroExpediente);
        public void AddCaracteristicas(CaracteristicasDto caracteristicas);
    }
}