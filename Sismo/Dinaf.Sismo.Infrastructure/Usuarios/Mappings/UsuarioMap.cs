using Dinaf.Sismo.Domain.Usuarios.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Usuarios.Mappings
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("usuarioslogin");
            Id(x => x.Id, "id_usuario");
            Map(x => x.Nombre, "usr_nombre");
            Map(x => x.Perfil, "fk_perfil_id");
            Map(x => x.NombreUsuario, "usr_username");
            Map(x => x.Contraseña, "password");
            //Map(x => x.Unidad, "id_unidad");
            Map(x => x.Rol, "rol");
            Map(x => x.Estado, "estado");
        }
    }
}