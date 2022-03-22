using Dinaf.Sismo.Domain.Seguimientos.Entities;
using Dinaf.Sismo.Domain.Seguimientos.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.Seguimientos.Repositories
{
    public class SeguimientoRepository : NhRepositoryBase<MedidaProteccion, int>, IMedidaProteccionRepository
    {
        public IList<MedidaProteccion> GetByNumeroExpediente(string numeroExpediente)
        {
            return Session.Query<MedidaProteccion>().Where(x => x.NumeroExpediente == numeroExpediente).ToList();
        }
    }
}