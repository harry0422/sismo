using Dinaf.Sismo.Application.Usuarios.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Usuarios
{
    public interface IUnidadService
    {
        public IList<UnidadDto> ObtenerUnidades();
    }
}