using Dinaf.Sismo.Application.Anexos.DTOs;
using Dinaf.Sismo.Application.Anexos.Mappers;
using Dinaf.Sismo.Domain.Anexos.Repositories;

namespace Dinaf.Sismo.Application.Anexos
{
    public class AnexoService : IAnexoService
    {
        private readonly IAnexosRepository _anexosRepository;

        public AnexoService(IAnexosRepository anexosRepository)
        {
            _anexosRepository = anexosRepository;
        }

        public ListAnexosDto GetAnexos(NumeroExpedienteDto numeroExpediente)
        {
            return _anexosRepository.GetAnexosByNumeroExpediente(numeroExpediente.Valor).ToDto();
        }
    }
}