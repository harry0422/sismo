using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.Mappers;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IDetallePersonaRepository _detallePersonaRepository;
        private readonly IFotografiaService _fotografiaService;

        public PersonaService(
            IPersonaRepository personaRepository, 
            IDetallePersonaRepository detallePersonaRepository, 
            IFotografiaService fotografiaService)
        {
            _personaRepository = personaRepository;
            _detallePersonaRepository = detallePersonaRepository;
            _fotografiaService = fotografiaService;
        }

        public IList<PersonaDto> ObtenerPersonasPorExpediente(NumeroExpedienteDto numeroExpediente)
        {
            return _personaRepository.ObtenerPersonasDeExpediente(numeroExpediente.Valor).ToDto();
        }

        public void AgregarPersona(NuevaPersonaDto nuevaPersona)
        {
            Nombre nombre = new Nombre(nuevaPersona.PrimerNombre, nuevaPersona.SegundoNombre, nuevaPersona.PrimerApellido, nuevaPersona.SegundoApellido);
            DetallePersona detallePersona = new(nombre, nuevaPersona.Genero, nuevaPersona.Nna, nuevaPersona.Raza, nuevaPersona.Religion, DateTime.Parse(nuevaPersona.FechaNacimiento), nuevaPersona.Nacionalidad, nuevaPersona.UsuarioCreacion, nuevaPersona.ColorCabello, nuevaPersona.ColorOjos, nuevaPersona.ColorPiel, nuevaPersona.SignosFisicos, nuevaPersona.Ocupacion, nuevaPersona.Observaciones, null);

            _detallePersonaRepository.Insert(detallePersona);
            VincularPersona(new VincularPersonaDto(nuevaPersona.NumeroExpediente, detallePersona.Id, nuevaPersona.UsuarioCreacion, nuevaPersona.EnCalidad));
        }

        public void VincularPersona(VincularPersonaDto vincularPersona)
        {
            DetallePersona detallePersona = _detallePersonaRepository.Get(vincularPersona.PersonaId);
            Persona persona = new Persona(detallePersona, vincularPersona.NumeroExpediente, vincularPersona.UsuarioCreacion, vincularPersona.EnCalidad);

            _personaRepository.Insert(persona);
        }

        public IList<PersonaDto> ObtenerFamiliaresPorExpediente(NumeroExpedienteDto numeroExpediente)
        {
            return _personaRepository
                .ObtenerPersonasDeExpediente(numeroExpediente.Valor)
                .Where(persona => persona.EsFamiliar)
                .ToDto();
        }

        public void AgregarFotoDePerfil(FotoPerfilDto fotoPerfil)
        {
            string nombreArchivo = Guid.NewGuid().ToString() + "." + fotoPerfil.Formato;
            _fotografiaService.Guardar(nombreArchivo, fotoPerfil.RutaCarpeta, fotoPerfil.FotoBase64);
            DetallePersona detallePersona = _detallePersonaRepository.Get(fotoPerfil.PersonaId);
            detallePersona.FotoPerfil = nombreArchivo;
            _detallePersonaRepository.Update(detallePersona);
        }
    }
}