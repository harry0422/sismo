using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas
{
    public class CondicionMedicaService : ICondicionMedicaService
    {
        private readonly ICondicionMedicaRepository _condicionMedicaRepository;

        public CondicionMedicaService(ICondicionMedicaRepository condicionMedicaRepository)
        {
            _condicionMedicaRepository = condicionMedicaRepository;
        }

        public List<CondicionMedicaDto> GetCondicionesMedicas()
        {
            return _condicionMedicaRepository.GetAll().ToDto();
        }
    }
}