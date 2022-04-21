using Dinaf.Sismo.Domain.Buzon.Entities;
using Dinaf.Sismo.Domain.Buzon.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.Buzon.Repositories
{
    public class MensajeRepository : NhRepositoryBase<Mensaje, int>, IMensajeRepository
    {
        public IList<Mensaje> ObtenerPorUsuario(int usuarioId)
        {
            return Session.Query<Mensaje>()
                .Where(x => x.Caso.UsuarioAsignado == usuarioId)
                .ToList();
        }
    }
}