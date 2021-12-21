using Dinaf.Sismo.Application.Anexos.DTOs;
using Dinaf.Sismo.Domain.Anexos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Anexos.Mappers
{
    public static class AnexoMapper
    {
        public static AnexoDto ToDto(this Anexo anexo)
        {
            if (anexo is null) return null;

            AnexoDto dto = new AnexoDto();
            dto.FechaCreacion = anexo.FechaCreacion.ToString("dd/MM/yyyy");
            dto.Asunto = anexo.Asunto;
            dto.Contenido = anexo.Contenido;
            dto.UsuarioRemitente = anexo.UsuarioRemitente;
            dto.NumeroExpediente = anexo.NumeroExpediente;
            dto.Responsable = anexo.Responsable;
            dto.UnidadRemitente = anexo.UnidadRemitente;

            return dto;
        }

        public static ListAnexosDto ToDto(this IList<Anexo> anexos)
        {
            ListAnexosDto dto = new ListAnexosDto();
            if (anexos is null) return dto;

            foreach (var anexo in anexos)
            {
                dto.Detalles.Add(anexo.ToDto());
            }

            return dto;
        }
    }
}