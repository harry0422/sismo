using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
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
        private readonly IEmparejamientoRepository _emparejamientoRepository;
        private readonly ISeguimientoRepository _seguimientoRepository;
        private readonly ISolicitudAdopcionService _solicitudAdopcionService;
        private readonly IExpedienteNnaService _expedienteNnaService;

        public EmparejamientoService(
            IEmparejamientoRepository emparejamientoRepository, 
            ISeguimientoRepository seguimientoRepository, 
            ISolicitudAdopcionService solicitudAdopcionService, 
            IExpedienteNnaService expedienteNnaService)
        {
            _emparejamientoRepository = emparejamientoRepository;
            _seguimientoRepository = seguimientoRepository;
            _solicitudAdopcionService = solicitudAdopcionService;
            _expedienteNnaService = expedienteNnaService;
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

        //TODO: Mejorar algoritmo
        public IList<EmparejamientoDto> ObtenerEmparejamientos()
        {
            IList<EmparejamientoDto> resultado = new List<EmparejamientoDto>();
            IList<Emparejamiento> emparejamientos = _emparejamientoRepository.GetAll();
            IList<ExpedienteNnaDto> expedientes = _expedienteNnaService.GetNnaEstadoAdoptabilidad()
                .Where(x => emparejamientos.Select(x => x.ExpedienteNna).Contains(x.NumeroExpediente))
                .ToList();

            foreach (var expediente in expedientes)
            {
                EmparejamientoDto dto = new EmparejamientoDto();
                DatosNnaDto datosNnaDto = new DatosNnaDto();
                datosNnaDto.NumeroExpediente = expediente.NumeroExpediente;
                datosNnaDto.Nombre = expediente.DetalleNna.NombreCorto;
                datosNnaDto.NombreCompleto = expediente.DetalleNna.Nombre;
                datosNnaDto.NumeroIdentidad = "0801-1990-09306";
                datosNnaDto.FechaNacimiento = expediente.DetalleNna.FechaNacimiento;
                datosNnaDto.Edad = expediente.DetalleNna.Edad.ToString();
                datosNnaDto.Nacionalidad = expediente.DetalleNna.Nacionalidad;
                datosNnaDto.Genero = expediente.DetalleNna.Genero;
                datosNnaDto.Telefono = "99336655";
                datosNnaDto.Email = "testemail@gmail.com";

                dto.DatosNna = datosNnaDto;

                var x = emparejamientos.Where(x => x.ExpedienteNna == expediente.NumeroExpediente);

                foreach (var emparejamiento in x)
                {
                    DatosEmparejamientoDto datosEmparejamientoDto = new DatosEmparejamientoDto();
                    datosEmparejamientoDto.Id = emparejamiento.Id;
                    datosEmparejamientoDto.NumeroSolicitud = emparejamiento.SolicitudAdopcion;
                    datosEmparejamientoDto.Etapa = emparejamiento.Etapa.ToString();
                    dto.DatosEmparejamiento.Add(datosEmparejamientoDto);
                }

                resultado.Add(dto);
            }

            return resultado;
        }
        //TODO: Mejorar algoritmo
        public EmparejamientoDto ObtenerDetalleEmparejamiento(NumeroExpedienteNnaDto numeroExpediente)
        {
            EmparejamientoDto resultado = new EmparejamientoDto();
            IList<Emparejamiento> emparejamientos = _emparejamientoRepository.ObtenerPorNumeroExpediente(numeroExpediente.Valor);
            ExpedienteNnaDto expediente = _expedienteNnaService.GetNnaEstadoAdoptabilidad(numeroExpediente);

            DatosNnaDto datosNnaDto = new DatosNnaDto();
            datosNnaDto.NumeroExpediente = expediente.NumeroExpediente;
            datosNnaDto.Nombre = expediente.DetalleNna.NombreCorto;
            datosNnaDto.NombreCompleto = expediente.DetalleNna.Nombre;
            datosNnaDto.NumeroIdentidad = "0801-1990-09306";
            datosNnaDto.FechaNacimiento = expediente.DetalleNna.FechaNacimiento;
            datosNnaDto.Edad = expediente.DetalleNna.Edad.ToString();
            datosNnaDto.Nacionalidad = expediente.DetalleNna.Nacionalidad;
            datosNnaDto.Genero = expediente.DetalleNna.Genero;
            datosNnaDto.Telefono = "99336655";
            datosNnaDto.Email = "testemail@gmail.com";

            resultado.DatosNna = datosNnaDto;

            var x = emparejamientos.Where(x => x.ExpedienteNna == expediente.NumeroExpediente);

            foreach (var emparejamiento in x)
            {
                DatosEmparejamientoDto datosEmparejamientoDto = new DatosEmparejamientoDto();
                datosEmparejamientoDto.Id = emparejamiento.Id;
                datosEmparejamientoDto.NumeroSolicitud = emparejamiento.SolicitudAdopcion;
                datosEmparejamientoDto.Etapa = emparejamiento.Etapa.ToString();
                resultado.DatosEmparejamiento.Add(datosEmparejamientoDto);
            }

            return resultado;
        }

        public void CrearPreEmparejamiento(NuevoEmparejamientoDto dto)
        {
            Emparejamiento emparejamiento = new Emparejamiento(dto.ExpedienteNna, dto.SolicitudAdopcion);
            emparejamiento.AgregarSeguimiento(Etapa.PreEmparejamiento, dto.Fecha, dto.Observaciones, dto.Usuario);
            
            _emparejamientoRepository.Insert(emparejamiento);
        }

        public void CrearAvanzarEtapa(InformacionSeguimientoDto dto)
        {
            Emparejamiento emparejamiento = _emparejamientoRepository.Get(dto.Id);            
            Etapa nuevaEtapa =  (Etapa)(int)emparejamiento.Etapa + 1;

            emparejamiento.AgregarSeguimiento(nuevaEtapa, dto.Fecha, dto.Observaciones, dto.Usuario);
            emparejamiento.Etapa = nuevaEtapa;

            _emparejamientoRepository.Update(emparejamiento);
        }

        //TODO: Pasar logica de mapeo a mapper propio 
        public IList<SeguimientoDto> ObtenerSeguimientos()
        {
            IList<SeguimientoDto> resultado = new List<SeguimientoDto>();
            IList<DetalleSeguimiento> seguimientos = _seguimientoRepository.GetAll();

            foreach (var seguimiento in seguimientos)
            {
                SeguimientoDto dto = new SeguimientoDto();
                dto.Id = seguimiento.Id;
                dto.ExpedienteNna = seguimiento.Emparejamiento.ExpedienteNna;
                dto.SolicitudAdopcion = seguimiento.Emparejamiento.SolicitudAdopcion;
                dto.Etapa = seguimiento.Etapa.ToString();
                dto.Fecha = seguimiento.Fecha.ToString("dd/MM/yyyy");
                dto.Observaciones = seguimiento.Observaciones;
                dto.Usuario = seguimiento.Usuario;

                resultado.Add(dto);
            }

            return resultado;
        }

        //TODO: Pasar logica de mapeo a mapper propio 
        public IList<SeguimientoDto> ObtenerSeguimientos(EmparejamientoIdDto emparejamientoId)
        {
            IList<SeguimientoDto> resultado = new List<SeguimientoDto>();
            IList<DetalleSeguimiento> seguimientos = _seguimientoRepository.GetByEmparejamientoId(emparejamientoId.Valor);

            foreach (var seguimiento in seguimientos)
            {
                SeguimientoDto dto = new SeguimientoDto();
                dto.Id = seguimiento.Id;
                dto.ExpedienteNna = seguimiento.Emparejamiento.ExpedienteNna;
                dto.SolicitudAdopcion = seguimiento.Emparejamiento.SolicitudAdopcion;
                dto.Etapa = seguimiento.Etapa.ToString();
                dto.Fecha = seguimiento.Fecha.ToString("dd/MM/yyyy");
                dto.Observaciones = seguimiento.Observaciones;
                dto.Usuario = seguimiento.Usuario;

                resultado.Add(dto);
            }

            return resultado;
        }
    }
}