using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Vulneraciones.DTOs
{
    public class ListVulneracionesDto
    {
        public ListVulneracionesDto()
        {
            Vulneraciones = new List<VulneracionDto>();
        }

        public IList<VulneracionDto> Vulneraciones { get; set; }
    }
}