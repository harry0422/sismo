using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Models
{
    public class ExpedienteViewModel
    {
        public ExpedienteViewModel(ExpedienteDto expediente, IList<PersonaDto> personas)
        {
            Expediente = expediente;
            Personas = personas;
        }

        public ExpedienteDto Expediente { get; set; }
        public IList<PersonaDto> Personas { get; set; }

    }
}