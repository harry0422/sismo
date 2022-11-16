using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Repositories
{
    public class NnaEmparejamientoRepository : NhRepositoryBase<NnaEmparejamiento, string>, INnaEmparejamientoRepository
    {
        public IList<NnaEmparejamiento> GetAll()
        {
            return Session.Query<NnaEmparejamiento>()
                .Where(x => x.Emparejamientos.Any())
                .ToList();
        }

        public NnaEmparejamiento ObtenerPorNumeroExpediente(string numeroExpediente)
        {
            return Session.Query<NnaEmparejamiento>()
                .Where(x => x.Id == numeroExpediente)
                .FirstOrDefault();
        }
    }
}