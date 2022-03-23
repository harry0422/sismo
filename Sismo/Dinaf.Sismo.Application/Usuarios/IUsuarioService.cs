using Dinaf.Sismo.Application.Usuarios.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Usuarios
{
    public interface IUsuarioService
    {
        IList<UsuarioDto> ObtenerTodos();
        UsuarioDto ObtenerPor(CredencialesDto credenciales);
        void CrearCredenciales(CredencialesDto credenciales);
    }
}