using Dinaf.Sismo.Application.Seguimientos.DTOs;

namespace Dinaf.Sismo.Application.Seguimientos
{
    public interface ISeguimientoService
    {
        ListSeguimientosDto GetMedidasProteccion(NumeroExpedienteDto numeroExpediente);
    }
}