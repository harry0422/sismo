using Dinaf.Sismo.Domain.Usuarios.Entities;
using Dinaf.Sismo.Domain.Usuarios.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.Usuarios.Repositories
{
    public class UsuarioRepository : NhRepositoryBase<Usuario, int>, IUsuarioRepository
    {
        public Usuario GetByNombreUsuario(string nombreUsuario)
        {
            return Session.Query<Usuario>()
                .Where(x => x.NombreUsuario == nombreUsuario)
                .FirstOrDefault();
        }
    }
}