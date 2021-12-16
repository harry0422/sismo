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
            dto.Articulo = vulneracion.TipoVulneracion is null ? "" : vulneracion.TipoVulneracion.Artuculo;
            dto.Tipoligia = vulneracion.TipoVulneracion is null ? "" : vulneracion.TipoVulneracion.Tipologia;

            return dto;
        }

        public static ListVulneracionesDto ToDto(this IList<Vulneracion> vulneraciones)
        {
            ListVulneracionesDto dto = new ListVulneracionesDto();

            foreach (var vulneracion in vulneraciones)
            {
                dto.Vulneraciones.Add(vulneracion.ToDto());
            }

            return dto;
        }
    }
}