using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories
{
    public interface IExpedienteNnaRepository : IRepository<ExpedienteNna, int>
    {
        public ExpedienteNna GetByNumeroExpedienteNna(string numeroExpediente);
    }
}