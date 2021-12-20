using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Seguimientos.DTOs
{
    public class ListSeguimientosDto
    {
        public ListSeguimientosDto()
        {
            Seguimientos = new List<SeguimientoDto>();
        }

        public IList<SeguimientoDto> Seguimientos { get; set; }
    }
}