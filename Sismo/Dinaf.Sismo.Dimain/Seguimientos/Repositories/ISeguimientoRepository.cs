using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.Seguimientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Seguimientos.Repositories
{
    public interface ISeguimientoRepository : IRepository<Seguimiento, int>
    {
        public IList<Seguimiento> GetByNumeroExpediente(string numeroExpediente);
    }
}