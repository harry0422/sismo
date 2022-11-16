using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.Mappers
{
    public static class NnaEmparejamientoMapper
    {
        //TODO: Agregar campos faltantes a entidad 
        public static NnaEmparejamientoDto ToDto(this NnaEmparejamiento nnaEmparejamiento)
        {
            if (nnaEmparejamiento is null) return null;

            NnaEmparejamientoDto dto = new NnaEmparejamientoDto();
            dto.NumeroExpediente = nnaEmparejamiento.NumeroExpediente;
            //dto.Nombre = nnaEmparejamiento.Nombre;
            //dto.NombreCompleto = nnaEmparejamiento.NombreCompleto;
            //dto.NumeroIdentidad = nnaEmparejamiento.NumeroIdentidad;
            //dto.FechaNacimiento = nnaEmparejamiento.FechaNacimiento;
            //dto.Edad = nnaEmparejamiento.Edad;
            //dto.Nacionalidad = nnaEmparejamiento.Nacionalidad;
            //dto.Genero = nnaEmparejamiento.Genero;
            //dto.FotoPerfil = nnaEmparejamiento.FotoPerfil;
            dto.DatosEmparejamiento = nnaEmparejamiento.Emparejamientos.ToDto();

            return dto;
        }

        public static IList<NnaEmparejamientoDto> ToDto(this IList<NnaEmparejamiento> nnaEmparejamientos)
        {
            if (nnaEmparejamientos is null) return null;

            IList<NnaEmparejamientoDto> dto = new List<NnaEmparejamientoDto>();

            foreach (var nnaEmparejamiento in nnaEmparejamientos)
            {
                dto.Add(nnaEmparejamiento.ToDto());
            }

            return dto;
        }
    }
}