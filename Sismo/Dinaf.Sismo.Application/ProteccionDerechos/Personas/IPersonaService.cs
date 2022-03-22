using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas
{
    public interface IPersonaService
    {
        IList<PersonaDto> GetPersonasByExpediente(NumeroExpedienteDto numeroExpediente);
        void AgregarPersona(NuevaPersonaDto nuevaPersona);
        void VincularPersona(VincularPersonaDto vincularPersona);
    }
}