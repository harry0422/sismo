using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public interface IExpedienteNnaService
    {
        public List<ExpedienteNnaDto> GetNnaEstadoAdoptabilidad();
        public ExpedienteNnaDto GetNnaEstadoAdoptabilidad(NumeroExpedienteDto numeroExpediente);
        public void AddCondicionMedica(AddCondicionMedicaDto addCondicionMedica);
    }
}