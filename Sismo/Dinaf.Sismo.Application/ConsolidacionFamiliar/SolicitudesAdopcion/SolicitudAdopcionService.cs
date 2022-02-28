using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public class SolicitudAdopcionService : ISolicitudAdopcionService
    {
        private readonly ISolicitudAdopcionRepository _solicitudAdopcionRepository;

        public SolicitudAdopcionService(ISolicitudAdopcionRepository solicitudAdopcionRepository)
        {
            _solicitudAdopcionRepository = solicitudAdopcionRepository;
        }

        public List<SolicitudAdopcionDto> GetSolicitudesAdopcion()
        {
            return _solicitudAdopcionRepository.GetAll().ToDto();
        }

        public SolicitudAdopcionDto GetSolicitudAdopcion(NumeroExpedienteDto numeroExpediente)
        {
            return _solicitudAdopcionRepository.Get(numeroExpediente.Valor).ToDto();
        }

        public void AddCaracteristicasAdopcion(CaracteristicasAdopcionDto caracteristicasAdopcion)
        {
            SolicitudAdopcion solicitudAdopcion = _solicitudAdopcionRepository.Get(caracteristicasAdopcion.NumeroExpediente);
            solicitudAdopcion.AgregarCaracteristicas(
                caracteristicasAdopcion.Genero,
                caracteristicasAdopcion.EdadMinima,
                caracteristicasAdopcion.EdadMaxima,
                caracteristicasAdopcion.CondicionMedica,
                caracteristicasAdopcion.CantidadHermanos);

            _solicitudAdopcionRepository.Update(solicitudAdopcion);

        }
    }
}