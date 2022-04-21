using Dinaf.Sismo.Domain.Buzon.Entities;
using Dinaf.Sismo.Domain.Common.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Buzon.Repositories
{
    public interface IMensajeRepository : IRepository<Mensaje, int>
    {
        public IList<Mensaje> ObtenerPorUsuario(int usuarioId);
    }
}