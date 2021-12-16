using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;

namespace Dinaf.Sismo.Models
{
    public class ExpedienteNiñoViewModel
    {
        public ExpedienteNiñoViewModel(ExpedienteDto expediente, ListVulneracionesDto vulneraciones)
        {
            Expediente = expediente;
            Vulneraciones = vulneraciones;
        }

        public ExpedienteDto Expediente { get; set; }
        public ListVulneracionesDto Vulneraciones { get; set; }
    }
}