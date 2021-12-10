using Dinaf.Sismo.Application.Contracts.Common.DTOs;
using Dinaf.Sismo.Application.Contracts.Personas;
using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Application.Personas.Mappers;
using Dinaf.Sismo.Domain.Personas.Repositories;

namespace Dinaf.Sismo.Application.Implementation.Personas
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public ListPersonasDto GetPersonas()
        {
            return _personaRepository.GetAll().ToDto();
        }

        public PersonaDto GetPersona(PersonaIdDto personaId)
        {
            return _personaRepository.Get(personaId.Valor).ToDto();
        }   
    }
}