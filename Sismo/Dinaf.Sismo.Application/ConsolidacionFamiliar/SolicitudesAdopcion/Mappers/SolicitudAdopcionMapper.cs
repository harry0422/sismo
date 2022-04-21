using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.SolicitudesAdopcion.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers
{
    public static class SolicitudAdopcionMapper
    {
        public static IList<SolicitudAdopcionDto> ToDto(this IList<SolicitudAdopcion> solicitudesAdopcion)
        {
            IList<SolicitudAdopcionDto> dto = new List<SolicitudAdopcionDto>();

            foreach (SolicitudAdopcion solicitudAdopcion in solicitudesAdopcion)
            {
                dto.Add(solicitudAdopcion.ToDto());
            }

            return dto;
        }

        public static SolicitudAdopcionDto ToDto(this SolicitudAdopcion solicitudAdopcion)
        {
            if (solicitudAdopcion is null) return null;

            SolicitudAdopcionDto dto = new SolicitudAdopcionDto();
            dto.NumeroExpediente = solicitudAdopcion.NumeroExpediente;
            dto.Nombres = string.Join(", ", solicitudAdopcion.SolicitantesAdopcion.Select(x => x.NombreCorto));
            dto.FechaCreacion = solicitudAdopcion.FechaCreacion.ToString("dd/MM/yyyy");
            dto.TipoInstrumento = solicitudAdopcion.TipoInstrumento;
            dto.Estado = solicitudAdopcion.Estado;
            dto.TipoSolicitud = solicitudAdopcion.TipoSolicitud;
            dto.Procedencia = solicitudAdopcion.Procedencia;
            dto.MotivoAdopcion = solicitudAdopcion.DescripcionMotivoAdopcion;
            dto.RepresentanteLegal = solicitudAdopcion.RepresentanteLegal is null ? "" : solicitudAdopcion.RepresentanteLegal.NombreCompleto;
            dto.Solicitantes = solicitudAdopcion.SolicitantesAdopcion.ToDto();
            dto.CaracteristicasAdopcionActual = solicitudAdopcion.CaracteristicasAdopcionActual.ToDto();
            dto.HistoricoDeBusquedas = solicitudAdopcion.HistoricoDeBusquedas.ToDto();

            return dto;
        }
    }
}