using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using Dinaf.Sismo.Application.Vulneraciones.Mappers;
using Dinaf.Sismo.Domain.Vulneraciones.Repositories;

namespace Dinaf.Sismo.Application.Vulneraciones
{
    public class VulneracionService : IVulneracionService
    {
        private readonly IVulneracionRepository _vulneracionRepository;

        public VulneracionService(IVulneracionRepository vulneracionRepository)
        {
            _vulneracionRepository = vulneracionRepository;
        }

        public ListVulneracionesDto GetVulneraciones(NumeroExpedienteDto numeroExpediente)
        {
            return _vulneracionRepository.GetByNumeroExpediente(numeroExpediente.Valor).ToDto();
        }

        public ListVulneracionesDto GetVulneraciones(TipoVulneracionIdDto tipoVulneracionId)
        {
            return _vulneracionRepository.GetBySubTipo(tipoVulneracionId.Valor).ToDto();
        }
    }
}