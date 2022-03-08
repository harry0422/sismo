using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.Mappers;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Repositories;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{

    public class ExpedienteNnaService : IExpedienteNnaService
    {
        private readonly IExpedienteNnaRepository _expedienteNnaRepository;
        private readonly ICondicionMedicaRepository _condicionMedicaRepository;

        public ExpedienteNnaService(IExpedienteNnaRepository expedienteNnaRepository, ICondicionMedicaRepository condicionMedicaRepository)
        {
            _expedienteNnaRepository = expedienteNnaRepository;
            _condicionMedicaRepository = condicionMedicaRepository;
        }

        public List<ExpedienteNnaDto> GetNnaEstadoAdoptabilidad()
        {
            return _expedienteNnaRepository.GetAll().ToDto();
        }

        public ExpedienteNnaDto GetNnaEstadoAdoptabilidad(NumeroExpedienteDto numeroExpediente)
        {
            return _expedienteNnaRepository.Get(numeroExpediente.Valor).ToDto();
        }

        public void AddCondicionMedica(AddCondicionMedicaDto addCondicionMedica)
        {
            CondicionMedica condicionMedica = _condicionMedicaRepository.Get(addCondicionMedica.CondicionMedica);
            ExpedienteNna expedienteNna = _expedienteNnaRepository.Get(addCondicionMedica.NumeroExpediente);
            expedienteNna.AgregarCondicionMedica(condicionMedica);

            _expedienteNnaRepository.Update(expedienteNna);
        }
    }
}