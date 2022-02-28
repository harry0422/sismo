using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.Mappers
{
    public static class CondicionMedicaMapper
    {
        public static List<CondicionMedicaDto> ToDto(this IList<CondicionMedica> condicionesMedica)
        {
            if (condicionesMedica is null) return null;

            List<CondicionMedicaDto> dto = new List<CondicionMedicaDto>();

            foreach (var condicionMedica in condicionesMedica)
            {
                dto.Add(condicionMedica.ToDto());
            }

            return dto;
        }

        public static CondicionMedicaDto ToDto(this CondicionMedica condicionMedica)
        {
            if (condicionMedica is null) return null;

            CondicionMedicaDto dto = new CondicionMedicaDto();
            dto.Id = condicionMedica.Id;
            dto.Descripcion = condicionMedica.Descripcion;

            return dto;
        }
    }
}