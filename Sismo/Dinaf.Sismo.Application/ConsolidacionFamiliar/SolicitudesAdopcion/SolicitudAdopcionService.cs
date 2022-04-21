using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
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

        public IList<SolicitudAdopcionDto> ObtenerSolicitudesAdopcion()
        {
            return _solicitudAdopcionRepository.GetAll().ToDto();
        }

        public SolicitudAdopcionDto ObtenerSolicitudAdopcion(NumeroSolicitudDto numeroSolicitud)
        {
            return _solicitudAdopcionRepository.Get(numeroSolicitud.Valor).ToDto();
        }

        public void AgregarCaracteristicasAdopcion(CaracteristicasAdopcionDto caracteristicasAdopcion)
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