using Dinaf.Sismo.Application.Common;
using Dinaf.Sismo.Application.Usuarios.DTOs;
using Dinaf.Sismo.Application.Usuarios.Mappers;
using Dinaf.Sismo.Domain.Usuarios.Entities;
using Dinaf.Sismo.Domain.Usuarios.Repositories;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Usuarios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ICifradoService _cifradoService;

        public UsuarioService(IUsuarioRepository usuarioRepository, ICifradoService cifradoService)
        {
            _usuarioRepository = usuarioRepository;
            _cifradoService = cifradoService;
        }

        public UsuarioDto ObtenerPor(CredencialesDto credenciales)
        {
            Usuario usuario = _usuarioRepository.GetByNombreUsuario(credenciales.NombreUsuario);
            if (usuario == null) throw new Exception("Usuario o contraseña incorrectos");

            bool contraseñaValida = _cifradoService.ValidarContraseña(credenciales.Contraseña, usuario.Contraseña);
            
            if (!contraseñaValida) throw new Exception("Usuario o contraseña incorrectos");

            return usuario.ToDto();
        }

        public void CrearCredenciales(CredencialesDto credenciales)
        {
            Usuario usuario = _usuarioRepository.GetByNombreUsuario(credenciales.NombreUsuario);
            if (usuario == null) throw new Exception("Usuario no existe en sismo");
            
            string contraseñaCifrada = _cifradoService.CifrarContraseña(credenciales.Contraseña);
            usuario.Contraseña = contraseñaCifrada;
            
            _usuarioRepository.Update(usuario);
        }

        public IList<UsuarioDto> ObtenerTodos()
        {
            return _usuarioRepository.GetAll().ToDto();
        }
    }
}