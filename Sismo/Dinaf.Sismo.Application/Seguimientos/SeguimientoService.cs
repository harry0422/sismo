using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Application.Seguimientos.Mappers;
using Dinaf.Sismo.Domain.Seguimientos.Repositories;

namespace Dinaf.Sismo.Application.Seguimientos
{
    public class SeguimientoService : ISeguimientoService
    {
        private readonly ISeguimientoRepository _seguimientoRepository;

        public SeguimientoService(ISeguimientoRepository seguimientoRepository)
        {
            _seguimientoRepository = seguimientoRepository;
        }

        public ListSeguimientosDto GetMedidasProteccion(NumeroExpedienteDto numeroExpediente)
        {
            return _seguimientoRepository.GetByNumeroExpediente(numeroExpediente.Valor).ToDto();
        }
    }
}