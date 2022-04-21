using Dinaf.Sismo.Application.Usuarios.DTOs;
using Dinaf.Sismo.Domain.Usuarios.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Usuarios.Mappers
{
    public static class UsuarioMapper
    {
        public static IList<UsuarioDto> ToDto(this IList<Usuario> usuarios)
        {
            if (usuarios is null) return null;

            IList<UsuarioDto> dto = new List<UsuarioDto>();

            foreach (var usuario in usuarios)
            {
                dto.Add(usuario.ToDto());
            }

            return dto;
        }

        public static UsuarioDto ToDto(this Usuario usuario)
        {
            if (usuario is null) return null;

            UsuarioDto dto = new UsuarioDto();
            dto.Id = usuario.Id;
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