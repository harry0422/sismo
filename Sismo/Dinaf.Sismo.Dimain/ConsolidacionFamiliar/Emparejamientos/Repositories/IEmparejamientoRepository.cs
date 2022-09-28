using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories
{
    public interface IEmparejamientoRepository : IRepository<Emparejamiento, string>
    {
        public IList<Emparejamiento> ObtenerPorNumeroExpediente(string numeroExpediente);
    }
}