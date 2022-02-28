using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos
{
    public class EmparejamientoService : IEmparejamientoService
    {
        private readonly IEmparejamientoRepository _emparejamientoRepository;

        public EmparejamientoService(IEmparejamientoRepository emparejamientoRepository)
        {
            _emparejamientoRepository = emparejamientoRepository;
        }

        public void CrearPreEmparejamiento(NuevoEmparejamientoDto dto)
        {
            DetalleSeguimiento detalleSeguimiento = new DetalleSeguimiento(Etapa.PreEmparejamiento, dto.Fecha, dto.Observaciones, dto.Usuario);
            Emparejamiento emparejamiento = new Emparejamiento(dto.ExpedienteNna, dto.SolicitudAdopcion, detalleSeguimiento);
            _emparejamientoRepository.Insert(emparejamiento);
        }

        public void CrearAvanzarEtapa(InformacionSeguimientoDto dto)
        {
            throw new NotImplementedException();
        }

        public List<PreEmparejamientoDto> ObtenerNnaPreEmparejamiento(NumeroExpedienteDto numeroExpediente)
        {
            throw new NotImplementedException();
        }

        public List<PreEmparejamientoDto> ObtenerSolicitudPreEmparejamiento(NumeroExpedienteDto numeroExpediente)
        {
            throw new NotImplementedException();
        }
    }
}