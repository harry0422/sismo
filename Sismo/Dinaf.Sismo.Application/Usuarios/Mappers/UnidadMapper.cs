using Dinaf.Sismo.Application.Usuarios.DTOs;
using Dinaf.Sismo.Domain.Usuarios.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Usuarios.Mappers
{
    public static class UnidadMapper
    {
        public static IList<UnidadDto> ToDto(this IList<Unidad> unidades)
        {
            IList<UnidadDto> dto = new List<UnidadDto>();

            foreach (Unidad unidad in unidades)
            {
                dto.Add(unidad.ToDto());
            }

            return dto;
        }

        public static UnidadDto ToDto(this Unidad unidad)
        {
            if (unidad is null) return null;

            UnidadDto dto = new UnidadDto();
            dto.Id = unidad.Id;
            dto.Descripcion = unidad.Descripcion;
            dto.Centro = unidad.Centro;
            dto.Tipo = unidad.Tipo;
            dto.EstadoUnidad = unidad.EstadoUnidad;

            return dto;
        }
    }
}