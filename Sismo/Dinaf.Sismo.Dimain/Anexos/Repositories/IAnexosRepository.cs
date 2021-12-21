using Dinaf.Sismo.Domain.Anexos.Entities;
using Dinaf.Sismo.Domain.Common.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Anexos.Repositories
{
    public interface IAnexosRepository : IRepository<Anexo, int>
    {
        IList<Anexo> GetAnexosByNumeroExpediente(string numeroExpediente);
    }
}