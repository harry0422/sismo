using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories
{
    public interface IExpedienteNnaRepository : IRepository<ExpedienteNna, string>
    {
        public IList<ExpedienteNna> GetExpedientesNnaEstadoAdopcion();
    }
}