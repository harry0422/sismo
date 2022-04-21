using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Application.Usuarios.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Models
{
    public class ExpedienteViewModel
    {
        public ExpedienteViewModel(ExpedienteDto expediente, IList<PersonaDto> personas, IList<UnidadDto> unidades)
        {
            Expediente = expediente;
            Personas = personas;
            Unidades = unidades;
        }

        public ExpedienteDto Expediente { get; set; }
        public IList<PersonaDto> Personas { get; set; }
        public IList<UnidadDto> Unidades { get; set; }

    }
}