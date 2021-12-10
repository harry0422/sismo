using Dinaf.Sismo.Application.Expedientes.DTOs;
using Dinaf.Sismo.Application.Expedientes.Mappers;
using Dinaf.Sismo.Domain.Expedientes.Repositories;

namespace Dinaf.Sismo.Application.Expedientes
{
    public class ExpedienteService : IExpedienteService
    {
        private readonly IExpedienteRepository _expedienteRepository;

        public ExpedienteService(IExpedienteRepository expedienteRepository)
        {
            _expedienteRepository = expedienteRepository;
        }

        public ListExpedientesDto GetExpedientes()
        {
            return _expedienteRepository.GetAll().ToDto();
        }

        public ExpedienteDto GetExpediente(ExpedienteIdDto expedienteId)
        {
            return _expedienteRepository.Get(expedienteId.Valor).ToDto();
        }
    }
}