using Dinaf.Sismo.Application.Vulneraciones.DTOs;

namespace Dinaf.Sismo.Application.Vulneraciones
{
    public interface IVulneracionService
    {
        ListVulneracionesDto GetVulneraciones(NumeroExpedienteDto numeroExpediente); 
    }
}