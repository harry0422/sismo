using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas
{
    public interface ICondicionMedicaService
    {
        public List<CondicionMedicaDto> GetCondicionesMedicas();
    }
}