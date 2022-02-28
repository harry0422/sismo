using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.SolicitudesAdopcion.Mappers
{
    public static class CaracteristicasAdopcionMapper
    {
        public static CaracteristicasAdopcionDto ToDto(this CaracteristicasSolicitud caracteristicasSolicitud)
        {
            if (caracteristicasSolicitud is null) return new CaracteristicasAdopcionDto();

            CaracteristicasAdopcionDto dto = new CaracteristicasAdopcionDto();
            dto.Genero = caracteristicasSolicitud.Genero;
            dto.EdadMinima = caracteristicasSolicitud.EdadMinima;
            dto.EdadMaxima = caracteristicasSolicitud.EdadMaxima;
            dto.CondicionMedica = caracteristicasSolicitud.CondicionMedica;
            dto.CantidadHermanos = caracteristicasSolicitud.CantidadHermanos;

            return dto;
        }
    }
}