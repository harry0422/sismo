using Dinaf.Sismo.Application.Usuarios.DTOs;

namespace Dinaf.Sismo.Application.Usuarios
{
    public interface IUsuarioService
    {
        UsuarioDto ObtenerPor(CredencialesDto credenciales);
        void CrearCredenciales(CredencialesDto credenciales);
    }
}