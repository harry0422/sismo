using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Domain.Personas.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Personas.Mappers
{
    public static class ExpedienteMapper
    {
        public static ExpedienteDto ToDto(this PersonaExpediente expediente)
        {
            if (expediente is null) return null;

            ExpedienteDto dto = new ExpedienteDto();
            dto.Id = expediente.Id;
            dto.Persona = expediente.Persona.ToDto();
            dto.NumeroExpediente = expediente.NumeroExpediente;
            dto.UsuarioId = expediente.UsuarioId;
            dto.Fecha = expediente.Fecha.ToString("dd/MM/yyyy");
            dto.EnCalidad = expediente.Encalidad;
            dto.ExpNna = expediente.ExpNna;
            dto.Estado = expediente.Estado;
            dto.FechaEstado = expediente.FechaEstado.ToString("dd/MM/yyyy");
            dto.ClaveTemporal = expediente.ClaveTemporal;
            dto.Asunto = expediente.Asunto;

            return dto;
        }

        public static ListExpedientesDto ToDto(this IList<PersonaExpediente> expedientes)
        {
            ListExpedientesDto dto = new ListExpedientesDto();

            foreach (var expediente in expedientes)
            {
                dto.Expedientes.Add(expediente.ToDto());
            }

            return dto;
        }
    }
}