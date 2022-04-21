using Dinaf.Sismo.Application.ProteccionDerechos.MedidasProteccion.DTOs;
using Dinaf.Sismo.Domain.MedidasProteccion.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.MedidasProteccion.Mappers
{
    public static class MedidaProteccionMapper
    {
        public static MedidaProteccionDto ToDto(this MedidaProteccion seguimiento)
        {
            if (seguimiento is null) return null;

            MedidaProteccionDto dto = new MedidaProteccionDto();
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

        public static List<MedidaProteccionDto> ToDto(this IList<MedidaProteccion> medidasProteccion)
        {
            List<MedidaProteccionDto> dto = new List<MedidaProteccionDto>();

            foreach (var seguimiento in medidasProteccion)
            {
                dto.Add(seguimiento.ToDto());
            }

            return dto;
        }
    }
}