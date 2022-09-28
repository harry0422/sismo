using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
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
            IList<VulneracionDto> vulneraciones, 
            IList<MedidaProteccionDto> medidasProteccion, 
            IList<PersonaDto> familiares,
            IList<PreEmparejamientoSolicitudDto> preEmparejamientos)
        {
            ExpedienteNna = expedienteNna;
            Vulneraciones = vulneraciones;
            MedidasProteccion = medidasProteccion;
            Familiares = familiares;
            PreEmparejamientos = preEmparejamientos;
        }

        public ExpedienteNnaDto ExpedienteNna { get; set; }
        public IList<VulneracionDto> Vulneraciones { get; set; }
        public IList<MedidaProteccionDto> MedidasProteccion { get; set; }
        public IList<PersonaDto> Familiares { get; set; }
        public IList<PreEmparejamientoSolicitudDto> PreEmparejamientos { get; set; }
    }
}