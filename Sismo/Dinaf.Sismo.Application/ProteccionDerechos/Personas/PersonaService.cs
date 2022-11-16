using Dinaf.Sismo.Application.Common;
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
        private readonly IArchivosService _archivosService;

        public PersonaService(
            IPersonaRepository personaRepository, 
            IDetallePersonaRepository detallePersonaRepository, 
            IArchivosService archivosService)
        {
            _personaRepository = personaRepository;
            _detallePersonaRepository = detallePersonaRepository;
            _archivosService = archivosService;
        }

        public IList<PersonaDto> ObtenerPersonasPorExpediente(NumeroExpedienteDto numeroExpediente)
        {
            return _personaRepository.ObtenerPersonasDeExpediente(numeroExpediente.Valor).ToDto();
        }

        public void AgregarPersona(NuevaPersonaDto persona)
        {
            DetallePersona detallePersona = new PersonaBuilder()
                .ConNombre(persona.PrimerNombre, persona.SegundoNombre, persona.PrimerApellido, persona.SegundoApellido)
                .ConDatosGenerales(persona.Genero, persona.FechaNacimiento, persona.Nacionalidad)
                .ConDatosAdicionales(persona.Raza, persona.Religion, persona.Ocupacion)
                .ConCaracteristicasFisicas(persona.ColorCabello, persona.ColorOjos, persona.ColorPiel, persona.SignosFisicos)
                .ConObservaciones(persona.Observaciones)
                .ConUsuarioCreacion(persona.UsuarioCreacion)
                .ConNna(persona.Nna)
                .ObtenerInstancia();

            _detallePersonaRepository.Insert(detallePersona);
            VincularPersona(new VincularPersonaDto(persona.NumeroExpediente, detallePersona.Id, persona.UsuarioCreacion, persona.EnCalidad));
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
            try
            {
                string nombreArchivo = Guid.NewGuid().ToString() + "." + fotoPerfil.Formato;
                _archivosService.Guardar(nombreArchivo, fotoPerfil.RutaCarpeta, fotoPerfil.FotoBase64);
                DetallePersona detallePersona = _detallePersonaRepository.Get(fotoPerfil.PersonaId);
                detallePersona.FotoPerfil = nombreArchivo;
                _detallePersonaRepository.Update(detallePersona);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}