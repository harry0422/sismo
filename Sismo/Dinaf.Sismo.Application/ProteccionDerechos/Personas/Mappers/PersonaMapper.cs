using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas.Mappers
{
    public static class PersonaMapper
    {
        public static IList<PersonaDto> ToDto(this IEnumerable<Persona> personas)
        {
            if (personas is null) return null;

            IList<PersonaDto> dto = new List<PersonaDto>();

            foreach (var persona in personas)
            {
                dto.Add(persona.ToDto());
            }

            return dto;
        }

        public static PersonaDto ToDto(this Persona persona)
        {
            if (persona is null) return null;

            PersonaDto dto = new PersonaDto();
            dto.Id = persona.DetallePersona.Id;
            dto.NombreCorto = persona.DetallePersona.NombreCorto;
            dto.NombreCompleto = persona.DetallePersona.NombreCompleto;
            dto.Ocupacion = persona.DetallePersona.Ocupacion;
            dto.FechaNacimiento = persona.DetallePersona.FechaNacimiento.ToString("dd/MM/yyyy");
            dto.Edad = persona.DetallePersona.Edad;
            dto.Nacionalidad = persona.DetallePersona.Nacionalidad;
            dto.Genero = persona.DetallePersona.Genero;
            dto.Telefono = string.Empty;
            dto.Email = string.Empty;

            Relacion relacion = persona.DetallePersona.ObtenerRelacionParaInstrumento(persona.NumeroExpediente);

            dto.Estado = relacion is null ? string.Empty : relacion.Estado;
            dto.TipoParentesco = relacion is null ? string.Empty : relacion.TipoParentesco.Descripcion;

            return dto;
        }
    }
}