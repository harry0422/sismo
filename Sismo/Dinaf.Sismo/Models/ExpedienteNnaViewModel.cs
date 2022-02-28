using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Models
{
    public class ExpedienteNnaViewModel
    {
        public ExpedienteNnaViewModel(
            ExpedienteNnaDto expedienteNna, 
            List<CondicionMedicaDto> condicionesMedicas, 
            List<VulneracionDto> vulneraciones, 
            List<SeguimientoDto> medidasProteccion)
        {
            ExpedienteNna = expedienteNna;
            CondicionesMedicas = condicionesMedicas;
            Vulneraciones = vulneraciones;
            MedidasProteccion = medidasProteccion;
        }

        public ExpedienteNnaDto ExpedienteNna { get; set; }
        public List<CondicionMedicaDto> CondicionesMedicas { get; set; }
        public List<VulneracionDto> Vulneraciones { get; set; }
        public List<SeguimientoDto> MedidasProteccion { get; set; }
    }
}