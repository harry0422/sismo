using Dinaf.Sismo.Domain.Expedientes.Entities;
using Dinaf.Sismo.Domain.Expedientes.Repositories;
using Dinaf.Sismo.Infrastructure.Common;

namespace Dinaf.Sismo.Infrastructure.Expedientes.Repositories
{
    public class ExpedienteRepository : NhRepositoryBase<Expediente, int>, IExpedienteRepository
    {

    }
}