using Dinaf.Sismo.Application.Buzon.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Buzon
{
    public interface ITipoGestionService
    {
        public IList<TipoGestionDto> ObtenerTiposDeGestion();
    }
}