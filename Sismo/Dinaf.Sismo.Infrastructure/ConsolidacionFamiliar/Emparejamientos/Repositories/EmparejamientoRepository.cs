using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Repositories
{
    public class EmparejamientoRepository : NhRepositoryBase<Emparejamiento, string>, IEmparejamientoRepository
    {
        public IList<Emparejamiento> ObtenerPorNumeroExpediente(string numeroExpediente)
        {
            return Session.Query<Emparejamiento>().Where(x => x.ExpedienteNna == numeroExpediente).ToList();
        }
    }
}