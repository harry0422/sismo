using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.Mappers;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Repositories;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public IList<PersonaDto> GetPersonasByExpediente(NumeroExpedienteDto numeroExpediente)
        {
            return _personaRepository.GetPersonasByExpediente(numeroExpediente.Valor).ToDto();
        }

        public void AgregarPersona(NuevaPersonaDto nuevaPersona)
        {
            Nombre nombre = new Nombre(nuevaPersona.PrimerNombre, nuevaPersona.SegundoNombre, nuevaPersona.PrimerApellido, nuevaPersona.SegundoApellido);
            DetallePersona detallePersona = new(nombre, nuevaPersona.Genero, nuevaPersona.Nna, nuevaPersona.Raza, nuevaPersona.Religion, DateTime.Parse(nuevaPersona.FechaNacimiento), nuevaPersona.Nacionalidad, nuevaPersona.UsuarioCreacion, nuevaPersona.ColorCabello, nuevaPersona.ColorOjos, nuevaPersona.ColorPiel, nuevaPersona.SignosFisicos, nuevaPersona.Ocupacion, nuevaPersona.Observaciones, null);
            Persona persona = new Persona(detallePersona, nuevaPersona.NumeroExpediente, nuevaPersona.UsuarioCreacion, nuevaPersona.EnCalidad, nuevaPersona.Nna);

            _personaRepository.Insert(persona);
        }

        public void VincularPersona(VincularPersonaDto vincularPersona)
        {
            throw new NotImplementedException();
        }
    }
}