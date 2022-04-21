using Dinaf.Sismo.Application.Buzon.DTOs;
using Dinaf.Sismo.Domain.Buzon.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Buzon.Mappers
{
    public static class TipoGestionMapper
    {
        public static IList<TipoGestionDto> ToDto(this IList<TipoGestion> tiposGestion)
        {
            IList<TipoGestionDto> dto = new List<TipoGestionDto>();

            foreach (var tipoGestion in tiposGestion)
            {
                dto.Add(tipoGestion.ToDto());
            }

            return dto;
        }

        public static TipoGestionDto ToDto(this TipoGestion tipoGestion)
        {
            if (tipoGestion == null) return null;

            TipoGestionDto dto = new TipoGestionDto();
            dto.Id = tipoGestion.Id;
            dto.Descripcion = tipoGestion.Descripcion;

            return dto;
        }
    }
}