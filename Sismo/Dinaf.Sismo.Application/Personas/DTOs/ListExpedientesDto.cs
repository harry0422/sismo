using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Personas.DTOs
{
    public class ListExpedientesDto
    {
        public ListExpedientesDto()
        {
            Expedientes = new List<ExpedienteDto>();
        }

        public IList<ExpedienteDto> Expedientes { get; set; }
    }
}