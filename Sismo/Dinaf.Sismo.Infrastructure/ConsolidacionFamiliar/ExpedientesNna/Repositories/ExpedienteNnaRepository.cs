using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Repositories
{
    public class ExpedienteNnaRepository : NhRepositoryBase<ExpedienteNna, string>, IExpedienteNnaRepository
    {
        public IList<ExpedienteNna> GetExpedientesNna(IList<string> numerosExpedientes)
        {
            return Session.Query<ExpedienteNna>().Where(x => numerosExpedientes.Contains(x.NumeroExpediente)).ToList();
        }
    }
}