using Dinaf.Sismo.Domain.Anexos.Entities;
using Dinaf.Sismo.Domain.Anexos.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.Anexos.Repositories
{
    public class AnexoRepository : NhRepositoryBase<Anexo, int>, IAnexosRepository
    {
        public IList<Anexo> GetAnexosByNumeroExpediente(string numeroExpediente)
        {
            return Session.Query<Anexo>().Where(x => x.NumeroExpediente == numeroExpediente).ToList();
        }
    }
}