using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas
{
    public interface IPersonaService
    {
        public IList<PersonaDto> ObtenerPersonasPorExpediente(NumeroExpedienteDto numeroExpediente);
        public IList<PersonaDto> ObtenerFamiliaresPorExpediente(NumeroExpedienteDto numeroExpediente);
        public void AgregarPersona(NuevaPersonaDto nuevaPersona);
        public void VincularPersona(VincularPersonaDto vincularPersona);
        public void AgregarFotoDePerfil(FotoPerfilDto fotoPerfil);

    }
}