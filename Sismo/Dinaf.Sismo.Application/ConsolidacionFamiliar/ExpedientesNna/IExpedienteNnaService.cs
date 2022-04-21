using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public interface IExpedienteNnaService
    {
        public IList<ExpedienteNnaDto> GetNnaEstadoAdoptabilidad();
        public ExpedienteNnaDto GetNnaEstadoAdoptabilidad(NumeroExpedienteNnaDto numeroExpediente);
        public void AddCondicionMedica(AddCondicionMedicaDto addCondicionMedica);
    }
}