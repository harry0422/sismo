using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.Vulneraciones.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Vulneraciones.Repositories
{
    public interface IVulneracionRepository : IRepository<Vulneracion, int>
    {
        IList<Vulneracion> GetByNumeroExpediente(string numeroExpediente);
        IList<Vulneracion> GetBySubTipo(int subTipoVulneracion);
    }
}