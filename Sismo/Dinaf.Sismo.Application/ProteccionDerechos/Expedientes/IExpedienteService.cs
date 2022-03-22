using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ProteccionDerechos.Expedientes
{
    public interface IExpedienteService
    {
        public IList<ExpedienteDto> GetExpedientePorTipo(TipoExpedienteDto tipoExpediente);
        public ExpedienteDto GetExpediente(NumeroExpedienteDto numeroExpediente);
    }
}