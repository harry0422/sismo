using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.MedidasProteccion.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.MedidasProteccion.Repositories
{
    public interface IMedidaProteccionRepository : IRepository<MedidaProteccion, int>
    {
        public IList<MedidaProteccion> GetByNumeroExpediente(string numeroExpediente);
    }
}