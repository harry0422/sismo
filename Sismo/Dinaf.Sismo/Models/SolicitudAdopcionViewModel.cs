using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Models
{
    public class SolicitudAdopcionViewModel
    {
        public SolicitudAdopcionViewModel(SolicitudAdopcionDto solicitudAdopcion, IList<CondicionMedicaDto> condicionesMedicas)
        {
            SolicitudAdopcion = solicitudAdopcion;
            CondicionesMedicas = condicionesMedicas;
        }

        public SolicitudAdopcionDto SolicitudAdopcion { get; set; }
        public IList<CondicionMedicaDto> CondicionesMedicas { get; set; }
    }
}