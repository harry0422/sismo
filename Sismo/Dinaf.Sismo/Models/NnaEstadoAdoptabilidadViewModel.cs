using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;

namespace Dinaf.Sismo.Models
{
    public class NnaEstadoAdoptabilidadViewModel
    {
        public NnaEstadoAdoptabilidadViewModel(ExpedienteDto expediente, ListVulneracionesDto vulneraciones, ListSeguimientosDto medidasProteccion)
        {
            Expediente = expediente;
            Vulneraciones = vulneraciones;
            MedidasProteccion = medidasProteccion;
        }

        public ExpedienteDto Expediente { get; set; }
        public ListVulneracionesDto Vulneraciones { get; set; }
        public ListSeguimientosDto MedidasProteccion { get; set; }

    }
}