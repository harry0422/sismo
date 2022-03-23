using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.Usuarios.Entities;

namespace Dinaf.Sismo.Domain.Usuarios.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, int>
    {
        Usuario GetByNombreUsuario(string nombreUsuario);
    }
}