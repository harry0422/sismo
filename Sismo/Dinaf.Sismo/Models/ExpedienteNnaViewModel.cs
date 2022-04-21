using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.MedidasProteccion.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Models
{
    public class ExpedienteNnaViewModel
    {
        public ExpedienteNnaViewModel(
            ExpedienteNnaDto expedienteNna, 
            IList<CondicionMedicaDto> condicionesMedicas, 
            IList<VulneracionDto> vulneraciones, 
            IList<MedidaProteccionDto> medidasProteccion, 
            IList<PersonaDto> familiares)
        {
            ExpedienteNna = expedienteNna;
            CondicionesMedicas = condicionesMedicas;
            Vulneraciones = vulneraciones;
            MedidasProteccion = medidasProteccion;
            Familiares = familiares;
        }

        public ExpedienteNnaDto ExpedienteNna { get; set; }
        public IList<CondicionMedicaDto> CondicionesMedicas { get; set; }
        public IList<VulneracionDto> Vulneraciones { get; set; }
        public IList<MedidaProteccionDto> MedidasProteccion { get; set; }

        public IList<PersonaDto> Familiares { get; set; }
    }
}