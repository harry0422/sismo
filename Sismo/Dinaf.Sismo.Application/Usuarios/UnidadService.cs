using Dinaf.Sismo.Application.Usuarios.DTOs;
using Dinaf.Sismo.Application.Usuarios.Mappers;
using Dinaf.Sismo.Domain.Usuarios.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Usuarios
{
    public class UnidadService : IUnidadService
    {
        private readonly IUnidadRepository _unidadRepository;

        public UnidadService(IUnidadRepository unidadRepository)
        {
            _unidadRepository = unidadRepository;
        }

        public IList<UnidadDto> ObtenerUnidades()
        {
            return _unidadRepository.GetAll().ToDto();
        }
    }
}