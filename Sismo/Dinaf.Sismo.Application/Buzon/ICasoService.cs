using Dinaf.Sismo.Application.Buzon.DTOs;

namespace Dinaf.Sismo.Application.Buzon
{
    public interface ICasoService
    {
        public void CrearNuevoTicket(NuevoTicketDto nuevoTicket);
        public void CerrarCaso(CasoIdDto casoId);

    }
}
