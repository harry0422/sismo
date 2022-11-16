using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.Mappers
{
    public static class SeguimientoMapper
    {
        public static SeguimientoDto ToDto(this DetalleSeguimiento seguimiento)
        {
            if (seguimiento is null) return null;

            SeguimientoDto dto = new SeguimientoDto();
            dto.Id = seguimiento.Id;
            dto.ExpedienteNna = seguimiento.Emparejamiento.ExpedienteNna;
            dto.SolicitudAdopcion = seguimiento.Emparejamiento.SolicitudAdopcion;
            dto.Etapa = seguimiento.Etapa.ToString();
            dto.Fecha = seguimiento.Fecha.ToString("dd/MM/yyyy");
            dto.Observaciones = seguimiento.Observaciones;
            dto.Usuario = seguimiento.Usuario;

            return dto;
        }

        public static IList<SeguimientoDto> ToDto(this IList<DetalleSeguimiento> seguimientos)
        {
            if (seguimientos == null) return null;

            IList<SeguimientoDto> dto = new List<SeguimientoDto>();

            foreach (var seguimiento in seguimientos)
            {
                dto.Add(seguimiento.ToDto());
            }

            return dto;
        }
    }
}
