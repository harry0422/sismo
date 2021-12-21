using Dinaf.Sismo.Application.Anexos.DTOs;
using Dinaf.Sismo.Application.Personas.DTOs;

namespace Dinaf.Sismo.Models
{
    public class SolicitanteAdopcionViewModel
    {
        public SolicitanteAdopcionViewModel(ExpedienteDto expediente, AnexoDto motivoAdopcion)
        {
            Expediente = expediente;
            MotivoAdopcion = motivoAdopcion;
        }

        public ExpedienteDto Expediente { get; set; }
        public AnexoDto MotivoAdopcion { get; set; }
    }
}