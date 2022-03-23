using Dinaf.Sismo.Application.Usuarios.DTOs;
using Dinaf.Sismo.Domain.Usuarios.Entities;

namespace Dinaf.Sismo.Application.Usuarios.Mappers
{
    public static class UsuarioMapper
    {
        public static UsuarioDto ToDto(this Usuario usuario)
        {
            if (usuario is null) return null;

            UsuarioDto dto = new UsuarioDto();
            dto.Nombre = usuario.Nombre;
            dto.Perfil = usuario.Perfil;
            dto.NombreUsuario = usuario.NombreUsuario;
            dto.Unidad = usuario.Unidad;
            dto.Rol = usuario.Rol;
            dto.Estado = usuario.Estado;

            return dto;
        }
    }
}