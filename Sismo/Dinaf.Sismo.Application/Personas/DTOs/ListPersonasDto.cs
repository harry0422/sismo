using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Personas.DTOs
{
    public class ListPersonasDto
    {
        public ListPersonasDto()
        {
            Personas = new List<PersonaDto>();
        }

        public IList<PersonaDto> Personas { get; set; }
    }
}