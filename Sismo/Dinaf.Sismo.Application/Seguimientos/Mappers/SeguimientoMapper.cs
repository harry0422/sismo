using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Domain.Seguimientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Seguimientos.Mappers
{
    public static class SeguimientoMapper
    {
        public static SeguimientoDto ToDto(this Seguimiento seguimiento)
        {
            if (seguimiento is null) return null;

            SeguimientoDto dto = new SeguimientoDto();
            dto.Id = seguimiento.Id;
            dto.NumeroExpediente = seguimiento.NumeroExpediente;
            dto.TipoCustodio = seguimiento.TipoCustodio == null ? "" : seguimiento.TipoCustodio.Nombre;
            dto.FechaInicio = seguimiento.FechaInicio.ToString("dd/MM/yyyy");
            dto.FechaFinal = seguimiento.FechaFinal.ToString("dd/MM/yyyy");
            dto.Referencias = seguimiento.Referencias;
            dto.UsuarioRemitente = seguimiento.UsuarioRemitente;
            dto.TipoGestion = seguimiento.TipoGestion;
            dto.Estado = seguimiento.Estado;
            dto.UnidadRemitente = seguimiento.UnidadRemitente;

            return dto;
        }

        public static List<SeguimientoDto> ToDto(this IList<Seguimiento> seguimientos)
        {
            List<SeguimientoDto> dto = new List<SeguimientoDto>();

            foreach (var seguimiento in seguimientos)
            {
                dto.Add(seguimiento.ToDto());
            }

            return dto;
        }
    }
}