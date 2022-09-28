using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs
{
    public class EmparejamientoDto
    {
        public EmparejamientoDto()
        {
            DatosEmparejamiento = new List<DatosEmparejamientoDto>();
        }

        public DatosNnaDto DatosNna { get; set; }
        public IList<DatosEmparejamientoDto> DatosEmparejamiento { get; set; }
    }
}