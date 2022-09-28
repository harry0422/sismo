using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;

namespace Dinaf.Sismo.Models
{
    public class SolicitudAdopcionViewModel
    {
        public SolicitudAdopcionViewModel(SolicitudAdopcionDto solicitudAdopcion)
        {
            SolicitudAdopcion = solicitudAdopcion;
        }

        public SolicitudAdopcionDto SolicitudAdopcion { get; set; }
    }
}