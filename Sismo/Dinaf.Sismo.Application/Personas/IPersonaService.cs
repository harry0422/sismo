using Dinaf.Sismo.Application.Contracts.Common.DTOs;
using Dinaf.Sismo.Application.Personas.DTOs;

namespace Dinaf.Sismo.Application.Contracts.Personas
{
    public interface IPersonaService
    {
        ListPersonasDto GetPersonas();
        PersonaDto GetPersona(PersonaIdDto personaId);
    }
}