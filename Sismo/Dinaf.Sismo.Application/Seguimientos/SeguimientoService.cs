using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Application.Seguimientos.Mappers;
using Dinaf.Sismo.Domain.Seguimientos.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Seguimientos
{
    public class SeguimientoService : ISeguimientoService
    {
        private readonly ISeguimientoRepository _seguimientoRepository;

        public SeguimientoService(ISeguimientoRepository seguimientoRepository)
        {
            _seguimientoRepository = seguimientoRepository;
        }

        public List<SeguimientoDto> GetMedidasProteccion(NumeroExpedienteDto numeroExpediente)
        {
            return _seguimientoRepository.GetByNumeroExpediente(numeroExpediente.Valor).ToDto();
        }
    }
}