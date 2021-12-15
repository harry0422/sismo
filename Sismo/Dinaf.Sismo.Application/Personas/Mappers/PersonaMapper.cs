using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Domain.Personas.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.Personas.Mappers
{
    public static class PersonaMapper
    {
        public static PersonaDto ToDto(this Persona persona)
        {
            if (persona is null) return null;

            PersonaDto dto = new PersonaDto();
            dto.Id = persona.Id;
            dto.Nombre = persona.NombreCompleto;
            dto.Genero = persona.Genero;
            dto.Nna = persona.Nna;
            dto.Raza = persona.Raza;
            dto.Estado = persona.Estado;
            dto.Cobertura = persona.Cobertura;
            dto.Religion = persona.Religion;
            dto.FechaNacimiento = persona.FechaNacimiento.ToString("dd/MM/yyyy");
            dto.Nacionalidad = persona.Nacionalidad;
            dto.Fecha = persona.Fecha.ToString("dd/MM/yyyy");
            dto.UsuarioId = persona.UsuarioId;
            dto.ColorCabello = persona.ColorCabello;
            dto.ColorOjos = persona.ColorOjos;
            dto.ColorPiel = persona.ColorPiel;
            dto.SignosFisicos = persona.SignosFisicos;
            dto.Edad = persona.Edad;
            dto.Ocupacion = persona.Ocupacion;
            dto.Observaciones = persona.Observaciones;
            dto.ChildrenFirst = persona.ChildrenFirst;

            return dto;
        }

        public static ListPersonasDto ToDto(this IList<Persona> personas)
        {
            ListPersonasDto dto = new ListPersonasDto();
            personas.ToList().ForEach(persona => dto.Personas.Add(persona.ToDto()));

            return dto;
        }
    }
}