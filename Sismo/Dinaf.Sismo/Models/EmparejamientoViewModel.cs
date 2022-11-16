using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;

namespace Dinaf.Sismo.Models
{
    public class EmparejamientoViewModel
    {
        public EmparejamientoViewModel(NnaEmparejamientoDto nnaEmparejamiento, ExpedienteNnaDto expedienteNna)
        {
            NnaEmparejamiento = nnaEmparejamiento;
            ExpedienteNna = expedienteNna;
        }

        public NnaEmparejamientoDto NnaEmparejamiento { get; set; }
        public ExpedienteNnaDto ExpedienteNna { get; set; }
    }
}