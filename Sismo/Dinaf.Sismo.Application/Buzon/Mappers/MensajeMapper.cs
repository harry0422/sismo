using Dinaf.Sismo.Application.Buzon.DTOs;
using Dinaf.Sismo.Domain.Buzon.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Buzon.Mappers
{
    public static class MensajeMapper
    {
        public static IList<MensajeDto> ToDto(this IList<Mensaje> mensajes)
        {
            IList<MensajeDto> dto = new List<MensajeDto>();

            foreach (var mensaje in mensajes)
            {
                dto.Add(mensaje.ToDto());
            }

            return dto;
        }

        public static MensajeDto ToDto(this Mensaje mensaje )
        {
            if ( mensaje is null ) return null;

            var dto = new MensajeDto();
            dto.FechaCreacion = mensaje.FechaCreacion.ToString("dd/MM/yyyy");
            dto.Remitente = mensaje.Remitente;
            dto.UnidadRemitente = mensaje.UnidadRemitente;
            dto.Asunto = mensaje.Asunto;
            dto.Contenido = mensaje.Contenido;
            dto.Caso = mensaje.Caso.Id;
            dto.Tipo = mensaje.Tipo;
            dto.Leido = mensaje.Leido;

            return dto;
        }
    }
}