using Dinaf.Sismo.Application.Buzon.DTOs;
using Dinaf.Sismo.Application.Buzon.Mappers;
using Dinaf.Sismo.Domain.Buzon.Repositories;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Buzon
{
    public class TipoGestionService : ITipoGestionService
    {
        private readonly ITipoGestionRepository _tipoGestionRepository;

        public TipoGestionService(ITipoGestionRepository tipoGestionRepository)
        {
            _tipoGestionRepository = tipoGestionRepository;
        }

        public IList<TipoGestionDto> ObtenerTiposDeGestion()
        {
            return _tipoGestionRepository.GetAll().ToDto();
        }
    }
}