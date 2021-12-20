using Dinaf.Sismo.Application.Contracts.Personas;
using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Application.Personas.Mappers;
using Dinaf.Sismo.Domain.Personas.Repositories;

namespace Dinaf.Sismo.Application.Implementation.Personas
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IExpedienteRepository _expedienteRepository;

        public PersonaService(IPersonaRepository personaRepository, IExpedienteRepository expedienteRepository)
        {
            _personaRepository = personaRepository;
            _expedienteRepository = expedienteRepository;
        }

        public ListPersonasDto GetPersonas()
        {
            return _personaRepository.GetAll().ToDto();
        }

        public PersonaDto GetPersona(PersonaIdDto personaId)
        {
            return _personaRepository.Get(personaId.Valor).ToDto();
        }

        public ListExpedientesDto GetExpedientes()
        {
            return _expedienteRepository.GetAll().ToDto();
        }

        public ExpedienteDto GetExpediente(PersonaExpedienteIdDto expedienteId)
        {
            return _expedienteRepository.Get(expedienteId.Valor).ToDto();
        }

        public ListExpedientesDto GetNnaEstadoAdoptabilidad()
        {
            return _expedienteRepository.GetExpedientesNiños().ToDto();
        }

        public ListExpedientesDto GetSolicitantesAdopcion()
        {
            return _expedienteRepository.GetSolicitantesAdopcion().ToDto();
        }
    }
}