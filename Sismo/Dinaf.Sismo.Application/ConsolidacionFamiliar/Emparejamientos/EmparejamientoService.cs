using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
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
        private readonly IParametroEmparejamientoRepository _parametroEmparejamientoRepository;

        public List<PreEmparejamientoDto> ObtenerNnaParaPreEmparejamiento(NumeroSolicitudDto numeroSolicitud)
        {
            var parametros = _parametroEmparejamientoRepository.GetAll();

            throw new NotImplementedException();
        }

        public List<PreEmparejamientoDto> ObtenerSolicitantesParaPreEmparejamiento(NumeroExpedienteNnaDto numeroExpediente)
        {
            throw new NotImplementedException();
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
    }
}