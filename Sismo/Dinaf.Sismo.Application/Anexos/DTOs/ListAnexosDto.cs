using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Anexos.DTOs
{
    public class ListAnexosDto
    {
        public ListAnexosDto()
        {
            Detalles = new List<AnexoDto>();
        }

        public IList<AnexoDto> Detalles { get; set; }
    }
}