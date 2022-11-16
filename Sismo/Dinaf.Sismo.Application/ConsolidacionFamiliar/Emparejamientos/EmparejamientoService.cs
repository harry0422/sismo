using Dinaf.Sismo.Application.Common;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.Mappers;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos
{
    public class EmparejamientoService : IEmparejamientoService
    {
        private readonly INnaEmparejamientoRepository _nnaEmparejamientoRepository;
        private readonly ISeguimientoRepository _seguimientoRepository;
        private readonly ISolicitudAdopcionService _solicitudAdopcionService;
        private readonly IExpedienteNnaService _expedienteNnaService;
        private readonly IArchivosService _archivosService;

        public EmparejamientoService(
            INnaEmparejamientoRepository nnaEmparejamientoRepository, 
            ISeguimientoRepository seguimientoRepository, 
            ISolicitudAdopcionService solicitudAdopcionService, 
            IExpedienteNnaService expedienteNnaService, 
            IArchivosService archivosService)
        {
            _nnaEmparejamientoRepository = nnaEmparejamientoRepository;
            _seguimientoRepository = seguimientoRepository;
            _solicitudAdopcionService = solicitudAdopcionService;
            _expedienteNnaService = expedienteNnaService;
            _archivosService = archivosService;
        }

        //TODO: Revisar implementacion de algoritmo
        public IList<PreEmparejamientoNnaDto> ObtenerNnaParaPreEmparejamiento(NumeroSolicitudDto numeroSolicitud)
        {
            IList<PreEmparejamientoNnaDto> resultado = new List<PreEmparejamientoNnaDto>();
            IList<ExpedienteNnaDto> expedientes = _expedienteNnaService.GetNnaEstadoAdoptabilidad();
            Random rand = new Random();

            foreach (var expediente in expedientes.Take(10))
            {

                resultado.Add(new PreEmparejamientoNnaDto()
                {
                    Nombre = expediente.DetalleNna.Nombre,
                    NumeroExpediente = expediente.NumeroExpediente,
                    PorcetajeCoincidencia = rand.Next(100),
                    Genero = expediente.DetalleNna.Genero,
                    Edad = expediente.DetalleNna.Edad,
                    CondicionMedica = expediente.DetalleNna.CondicionMedica ?? "Ninguna",
                    Hermanos = rand.Next(3)
                });
            }

            return resultado.OrderByDescending(x => x.PorcetajeCoincidencia).ToList(); ;
        }

        //TODO: Revisar implementacion de algoritmo
        public IList<PreEmparejamientoSolicitudDto> ObtenerSolicitantesParaPreEmparejamiento(NumeroExpedienteNnaDto numeroExpediente)
        {
            IList<PreEmparejamientoSolicitudDto> resultado = new List<PreEmparejamientoSolicitudDto>();
            IList<SolicitudAdopcionDto> solicitudesAdopcion = _solicitudAdopcionService.ObtenerSolicitudesAdopcion();
            Random rand = new Random();

            foreach (var solicitudAdopcion in solicitudesAdopcion.Take(10))
            {

                resultado.Add(new PreEmparejamientoSolicitudDto()
                {
                    NumeroExpediente = solicitudAdopcion.NumeroExpediente,
                    Nombres = solicitudAdopcion.Nombres,
                    FechaCreacion = solicitudAdopcion.FechaCreacion,
                    TipoInstrumento = solicitudAdopcion.TipoInstrumento,
                    TipoSolicitud = solicitudAdopcion.TipoSolicitud,
                    PorcetajeCoincidencia = rand.Next(100)
                });
            }

            return resultado.OrderByDescending(x => x.PorcetajeCoincidencia).ToList();
        }

        public IList<NnaEmparejamientoDto> ObtenerEmparejamientos()
        {
            return _nnaEmparejamientoRepository.GetAll().ToDto();
        }

        public NnaEmparejamientoDto ObtenerDetalleEmparejamiento(NumeroExpedienteNnaDto numeroExpediente)
        {
           return _nnaEmparejamientoRepository
                .ObtenerPorNumeroExpediente(numeroExpediente.Valor)
                .ToDto();
        }

        public void CrearPreEmparejamiento(NuevoEmparejamientoDto dto)
        {
            NnaEmparejamiento nnaEmparejamiento = _nnaEmparejamientoRepository.ObtenerPorNumeroExpediente(dto.ExpedienteNna);
            nnaEmparejamiento.AgregarEmparejamiento(dto.SolicitudAdopcion, dto.Fecha, dto.Observaciones, dto.Usuario);
            _nnaEmparejamientoRepository.Update(nnaEmparejamiento);
        }

        public void CrearAvanzarEtapa(InformacionSeguimientoDto dto)
        {
            bool tieneAdjunto = dto.NombreArchivo != null && dto.Base64 != null;

            NnaEmparejamiento nnaEmparejamiento = _nnaEmparejamientoRepository.ObtenerPorNumeroExpediente(dto.ExpedienteNna);
            Emparejamiento emparejamiento = nnaEmparejamiento.ObtenerEmparejamientoPorId(dto.Id);
            emparejamiento.AgregarSeguimiento(dto.Fecha, dto.Observaciones, dto.Usuario, tieneAdjunto);

            if (tieneAdjunto)
            {
                var nombreArchivo = emparejamiento.Seguimientos.LastOrDefault().Id + "_" + dto.NombreArchivo;
                _archivosService.Guardar(nombreArchivo, dto.RutaCarpeta, dto.Base64);
            }
            
            _nnaEmparejamientoRepository.Update(nnaEmparejamiento);
        }

        public IList<SeguimientoDto> ObtenerSeguimientos()
        {
            return _seguimientoRepository.GetAll().ToDto();
        }

        public IList<SeguimientoDto> ObtenerSeguimientos(EmparejamientoIdDto emparejamientoId)
        {
            return _seguimientoRepository.GetByEmparejamientoId(emparejamientoId.Valor).ToDto();
        }
    }
}