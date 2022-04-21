using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.SolicitudesAdopcion.Mappers
{
    public static class CaracteristicasAdopcionMapper
    {
        public static IList<CaracteristicasAdopcionDto> ToDto(this IList<CaracteristicasAdopcion> caracteristicasAdopcion)
        {
            IList<CaracteristicasAdopcionDto> dto = new List<CaracteristicasAdopcionDto>();

            foreach (var c in caracteristicasAdopcion)
            {
                dto.Add(c.ToDto());
            }

            return dto;
        }

        public static CaracteristicasAdopcionDto ToDto(this CaracteristicasAdopcion caracteristicasSolicitud)
        {
            if (caracteristicasSolicitud is null) return new CaracteristicasAdopcionDto();

            CaracteristicasAdopcionDto dto = new CaracteristicasAdopcionDto();
            dto.Genero = caracteristicasSolicitud.Genero;
            dto.EdadMinima = caracteristicasSolicitud.EdadMinima;
            dto.EdadMaxima = caracteristicasSolicitud.EdadMaxima;
            dto.CondicionMedica = caracteristicasSolicitud.CondicionMedica;
            dto.CantidadHermanos = caracteristicasSolicitud.CantidadHermanos;
            dto.FechaCreacion = caracteristicasSolicitud.FechaCreacion.ToString("dd/MM/yyyyy");

            return dto;
        }
    }
}