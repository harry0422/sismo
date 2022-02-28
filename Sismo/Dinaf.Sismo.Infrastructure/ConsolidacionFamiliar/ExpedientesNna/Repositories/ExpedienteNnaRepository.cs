using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Repositories
{
    public class ExpedienteNnaRepository : NhRepositoryBase<ExpedienteNna, string>, IExpedienteNnaRepository
    {
        public IList<ExpedienteNna> GetExpedientesNnaEstadoAdopcion()
        {
            throw new System.NotImplementedException();
        }
    }
}