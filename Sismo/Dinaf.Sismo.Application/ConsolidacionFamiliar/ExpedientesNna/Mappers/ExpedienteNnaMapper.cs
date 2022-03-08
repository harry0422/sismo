using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.Mappers
{
    public static class ExpedienteNnaMapper
    {
        public static ExpedienteNnaDto ToDto(this ExpedienteNna expedienteNna)
        {
            if (expedienteNna is null) return null;

            ExpedienteNnaDto dto = new ExpedienteNnaDto();
            dto.NumeroExpediente = expedienteNna.NumeroExpediente;
            dto.FechaCreacion = expedienteNna.FechaCreacion.ToString("dd/MM/yyyy");
            dto.DetalleNna = expedienteNna.DetalleNna.ToDto();
            dto.Familiares = expedienteNna.Familiares.ToDto();

            return dto;
        }

        public static List<ExpedienteNnaDto> ToDto(this IList<ExpedienteNna> expedientesNna)
        {
            if (expedientesNna is null) return null;

            List<ExpedienteNnaDto> dto = new List<ExpedienteNnaDto>();


            foreach (var expedienteNna in expedientesNna)
            {
                dto.Add(expedienteNna.ToDto());
            }

            return dto;
        }

        public static List<FamiliarDto> ToDto(this IList<Persona> familiares)
        {
            if (familiares is null) return null;

            List<FamiliarDto> dto = new List<FamiliarDto>();


            foreach (var familiar in familiares)
            {
                dto.Add(familiar.DetallePersona.ToDto());
            }

            return dto;
        }

        public static FamiliarDto ToDto(this DetallePersona familiar)
        {
            if (familiar is null) return null;

            FamiliarDto dto = new FamiliarDto();
            dto.NombreCorto = familiar.NombreCorto;
            dto.Genero = familiar.Genero;
            dto.Estado = familiar.Estado;
            dto.Edad = familiar.Edad;
            dto.Nacionalidad = familiar.Nacionalidad;
            dto.Ocupacion = familiar.Ocupacion;
            dto.Relacion = familiar.Relaciones.FirstOrDefault() is null ? string.Empty : familiar.Relaciones.First().TipoParentesco.Descripcion;

            return dto;
        }
    }
}