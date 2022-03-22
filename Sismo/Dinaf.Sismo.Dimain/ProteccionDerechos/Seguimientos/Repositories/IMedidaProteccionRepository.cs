using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.Seguimientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Seguimientos.Repositories
{
    public interface IMedidaProteccionRepository : IRepository<MedidaProteccion, int>
    {
        public IList<MedidaProteccion> GetByNumeroExpediente(string numeroExpediente);
    }
}