using Dinaf.Sismo.Application.Expedientes.DTOs;

namespace Dinaf.Sismo.Application.Expedientes
{
    public interface IExpedienteService
    {
        ListExpedientesDto GetExpedientes();
        ExpedienteDto GetExpediente(ExpedienteIdDto expedienteId);
    }
}