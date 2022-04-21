using Dinaf.Sismo.Domain.MedidasProteccion.Entities;
using Dinaf.Sismo.Domain.MedidasProteccion.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.MedidasProteccion.Repositories
{
    public class MedidaProteccionRepository : NhRepositoryBase<MedidaProteccion, int>, IMedidaProteccionRepository
    {
        public IList<MedidaProteccion> GetByNumeroExpediente(string numeroExpediente)
        {
            return Session.Query<MedidaProteccion>().Where(x => x.NumeroExpediente == numeroExpediente).ToList();
        }
    }
}