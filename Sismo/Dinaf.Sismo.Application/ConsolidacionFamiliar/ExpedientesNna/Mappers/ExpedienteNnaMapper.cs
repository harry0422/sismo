using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.Mappers
{
    public static class ExpedienteNnaMapper
    {
        public static ExpedienteNnaDto ToDto(this ExpedienteNna expedienteNna)
        {
            if (expedienteNna is null) return null;

            ExpedienteNnaDto dto = new ExpedienteNnaDto();
            dto.NumeroExpediente = expedienteNna.NumeroExpediente;
            dto.FechaCreacion = expedienteNna.FechaCreacion.ToString("dd/MM/yyyy");
            dto.DetalleNna = expedienteNna.DetalleNna.ToDto();

            return dto;
        }

        public static List<ExpedienteNnaDto> ToDto(this IList<ExpedienteNna> expedientesNna)
        {
            if (expedientesNna is null) return null;

            List<ExpedienteNnaDto> dto = new List<ExpedienteNnaDto>();


            foreach (var expedienteNna in expedientesNna)
            {
                dto.Add(expedienteNna.ToDto());
            }

            return dto;
        }
    }
}