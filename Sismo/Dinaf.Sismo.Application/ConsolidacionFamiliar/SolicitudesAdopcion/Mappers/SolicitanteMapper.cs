using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers
{
    public static class SolicitanteMapper
    {
        public static SolicitanteDto ToDto(this DetallePersona detalleSolicitante)
        {
            if (detalleSolicitante is null) return null;

            SolicitanteDto dto = new SolicitanteDto();
            dto.Id = detalleSolicitante.Id;
            dto.Nombre = detalleSolicitante.NombreCompleto;
            dto.NombreCorto = detalleSolicitante.NombreCorto;
            dto.Genero = detalleSolicitante.Genero;
            dto.Estado = detalleSolicitante.Estado;
            dto.Edad = detalleSolicitante.Edad;
            dto.FechaNacimiento = detalleSolicitante.FechaNacimiento.ToString("dd/MM/yyyy");
            dto.Nacionalidad = detalleSolicitante.Nacionalidad;
            dto.Ocupacion = detalleSolicitante.Ocupacion;

            return dto;
        }

        public static IList<SolicitanteDto> ToDto(this IList<DetallePersona> detalleSolicitantes)
        {
            if (detalleSolicitantes is null) return null;

            IList<SolicitanteDto> dto = new List<SolicitanteDto>();

            foreach (var solicitante in detalleSolicitantes)
            {
                dto.Add(solicitante.ToDto());
            }

            return dto;
        }
    }
}