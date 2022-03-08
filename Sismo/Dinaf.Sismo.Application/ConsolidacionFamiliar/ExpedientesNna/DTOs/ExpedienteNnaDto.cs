using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs
{
    public class ExpedienteNnaDto
    {
        public string NumeroExpediente { get; set; }
        public string FechaCreacion { get; set; }
        public DetalleNnaDto DetalleNna { get; set; }
        public List<FamiliarDto> Familiares { get; set; }
    }
}