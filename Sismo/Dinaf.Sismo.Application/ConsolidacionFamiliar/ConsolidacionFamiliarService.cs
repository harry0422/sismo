using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{

    public class ConsolidacionFamiliarService : IConsolidacionFamiliarService
    {
        private readonly ISolicitudAdopcionRepository _solicitudAdopcionRepository;
        private readonly IExpedienteNnaRepository _expedienteNnaRepository;

        public ConsolidacionFamiliarService(ISolicitudAdopcionRepository solicitudAdopcionRepository, IExpedienteNnaRepository expedienteNnaRepository)
        {
            _solicitudAdopcionRepository = solicitudAdopcionRepository;
            _expedienteNnaRepository = expedienteNnaRepository;
        }

        public List<SolicitudAdopcionDto> GetSolicitudesAdopcion()
        {
            return _solicitudAdopcionRepository.GetAll().ToDto();
        }

        public SolicitudAdopcionDto GetSolicitudAdopcion(NumeroExpedienteDto numeroExpediente)
        {
            return _solicitudAdopcionRepository.Get(numeroExpediente.Valor).ToDto();
        }

        public List<ExpedienteNnaDto> GetNnaEstadoAdoptabilidad()
        {
            return _expedienteNnaRepository.GetAll().ToDto();
        }

        public ExpedienteNnaDto GetNnaEstadoAdoptabilidad(NumeroExpedienteDto numeroExpediente)
        {
            return _expedienteNnaRepository.Get(numeroExpediente.Valor).ToDto();
        }
    }
}