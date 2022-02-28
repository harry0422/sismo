using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using Dinaf.Sismo.Domain.Vulneraciones.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Vulneraciones.Mappers
{
    public static class VulneracionMapper
    {
        public static VulneracionDto ToDto(this Vulneracion vulneracion)
        {
            if (vulneracion is null) return null;

            VulneracionDto dto = new VulneracionDto();
            dto.Id = vulneracion.Id;
            dto.FechaCreacion = vulneracion.FechaCreacion.ToString("dd/MM/yyyy");
            dto.UsuarioRemitente = vulneracion.UsuarioRemitente;
            dto.NumeroInstrumento = vulneracion.NumeroInstrumento;
            dto.Articulo = vulneracion.SubTipoVulneracion.TipoVulneracion.Artuculo;
            dto.TipoVulneracion = vulneracion.SubTipoVulneracion.TipoVulneracion.Tipologia;
            dto.SubTipoVulneracion = vulneracion.SubTipoVulneracion.Tipologia;

            return dto;
        }

        public static List<VulneracionDto> ToDto(this IList<Vulneracion> vulneraciones)
        {
            List<VulneracionDto> dto = new List<VulneracionDto>();

            foreach (var vulneracion in vulneraciones)
            {
                dto.Add(vulneracion.ToDto());
            }

            return dto;
        }
    }
}