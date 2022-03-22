using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.Mappers;
using Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Expedientes
{
    public class ExpedienteService : IExpedienteService
    {
        private readonly IExpedienteRepository _expedienteRepository;

        public ExpedienteService(IExpedienteRepository expedienteRepository)
        {
            _expedienteRepository = expedienteRepository;
        }

        public IList<ExpedienteDto> GetExpedientePorTipo(TipoExpedienteDto tipoExpediente)
        {
            return _expedienteRepository.GetExpedientesByTipo(tipoExpediente.Valor).ToDto();
        }

        public ExpedienteDto GetExpediente(NumeroExpedienteDto numeroExpediente)
        {
            return _expedienteRepository.GetExpedienteByNumeroExpediente(numeroExpediente.Valor).ToDto();
        }
    }
}