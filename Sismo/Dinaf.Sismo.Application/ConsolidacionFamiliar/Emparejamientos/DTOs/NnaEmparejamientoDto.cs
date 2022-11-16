using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs
{
    public class NnaEmparejamientoDto
    {
        public NnaEmparejamientoDto()
        {
            DatosEmparejamiento = new List<DatosEmparejamientoDto>();
        }

        public string NumeroExpediente { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroIdentidad { get; set; }
        public string FechaNacimiento { get; set; }
        public string Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Genero { get; set; }
        public string FotoPerfil { get; set; }
        public IList<DatosEmparejamientoDto> DatosEmparejamiento { get; set; }
    }
}