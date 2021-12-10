using Dinaf.Sismo.Application.Expedientes.DTOs;
using Dinaf.Sismo.Domain.Expedientes.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.Expedientes.Mappers
{
    public static class ExpedienteMapper
    {
        public static ExpedienteDto ToDto(this Expediente expediente)
        {
            ExpedienteDto dto = new ExpedienteDto();
            dto.Id = expediente.Id;
            dto.NumeroExpediente = expediente.NumeroExpediente;
            dto.FechaCreacion = expediente.FechaCreacion.ToString("dd/MM/yyyy");
            //dto.Unidad = expediente.Unidad.Nombre;
            dto.Usuario = expediente.Usuario;
            dto.TipoInstrumento = expediente.TipoInstrumento;
            //dto.UnidadApertura = expediente.UnidadApertura.Nombre;
            dto.Tipo = expediente.Tipo;
            dto.NumeroAnterior = expediente.NumeroAnterior;
            dto.Estado = expediente.Estado;
            dto.AñoAnterior = expediente.AñoAnterior;
            dto.Procedencia = expediente.Procedencia;
            dto.Consentimiento = expediente.Consentimiento;
            dto.Cf = expediente.Cf;
            dto.UsuarioAsignado = expediente.UsuarioAsignado;
            dto.SFecha = expediente.SFecha.ToString("dd/MM/yyyy");
            dto.Issue = expediente.Issue;
            dto.FechaVulneracion = expediente.FechaVulneracion.ToString("dd/MM/yyyy");

            return dto;
        }

        public static ListExpedientesDto ToDto(this IList<Expediente> expedientes)
        {
            ListExpedientesDto dto = new ListExpedientesDto();
            expedientes.ToList().ForEach(expediente => dto.Expedientes.Add(expediente.ToDto()));

            return dto;
        }
    }
}