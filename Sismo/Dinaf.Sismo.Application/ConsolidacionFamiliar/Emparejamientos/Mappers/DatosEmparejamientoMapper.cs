using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.Mappers
{
    public static class DatosEmparejamientoMapper
    {
        //TODO: Mapear nombres de solicitantes 
        public static DatosEmparejamientoDto ToDto(this Emparejamiento emparejamiento)
        {
            if (emparejamiento is null) return null;

            DatosEmparejamientoDto dto = new DatosEmparejamientoDto();
            dto.Id = emparejamiento.Id;
            dto.SolicitudAdopcion = emparejamiento.SolicitudAdopcion;
            //dto.Solicitantes = emparejamiento.Solicitantes;
            dto.EtapaActual = emparejamiento.EtapaActual.ToString();
            dto.SiguienteEtapa = emparejamiento.SiguienteEtapa.ToString();

            return dto;
        }

        public static IList<DatosEmparejamientoDto> ToDto(this IList<Emparejamiento> emparejamientos)
        {
            if (emparejamientos is null) return null;

            IList<DatosEmparejamientoDto> dto = new List<DatosEmparejamientoDto>();

            foreach (var emparejamiento in emparejamientos)
            {
                dto.Add(emparejamiento.ToDto());
            }

            return dto;
        }
    }
}
