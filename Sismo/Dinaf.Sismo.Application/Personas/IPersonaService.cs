using Dinaf.Sismo.Application.Personas.DTOs;

namespace Dinaf.Sismo.Application.Contracts.Personas
{
    public interface IPersonaService
    {
        ListExpedientesDto GetExpedientes();
        ExpedienteDto GetExpediente(PersonaExpedienteIdDto expedienteId);
        ListPersonasDto GetPersonas();
        PersonaDto GetPersona(PersonaIdDto personaId);
        ListExpedientesDto GetExpedientesNiños();
        ListExpedientesDto GetExpedientesAdultos();
    }
}