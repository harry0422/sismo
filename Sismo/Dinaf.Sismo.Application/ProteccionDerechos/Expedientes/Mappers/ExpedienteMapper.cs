using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs;
using Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.Mappers
{
    public static class ExpedienteMapper
    {
        public static IList<ExpedienteDto> ToDto(this IList<Expediente> expedientes)
        {
            if (expedientes is null) return null;

            IList<ExpedienteDto> dto = new List<ExpedienteDto>();

            foreach (var expediente in expedientes)
            {
                dto.Add(expediente.ToDto());
            }

            return dto;
        }

        public static ExpedienteDto ToDto(this Expediente expediente)
        {
            if (expediente is null) return null;

            ExpedienteDto dto = new ExpedienteDto();
            dto.Id = expediente.Id;
            dto.NumeroExpediente = expediente.NumeroExpediente;
            dto.FechaCreacion = expediente.FechaCreacion.ToString("dd/MM/yyyy");
            dto.Unidad = expediente.Unidad.ToString();
            dto.Usuario = expediente.Usuario;
            dto.TipoInstrumento = expediente.TipoInstrumento;
            dto.UnidadApertura = expediente.UnidadApertura.ToString();
            dto.NumeroAnterior = expediente.NumeroAnterior;
            dto.Estado = expediente.Estado;
            dto.UsusarioAsignado = expediente.UsusarioAsignado;

            return dto;
        }
    }
}