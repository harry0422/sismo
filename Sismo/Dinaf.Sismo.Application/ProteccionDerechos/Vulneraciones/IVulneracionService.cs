using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Vulneraciones
{
    public interface IVulneracionService
    {
        List<VulneracionDto> GetVulneraciones(NumeroExpedienteDto numeroExpediente);
        List<VulneracionDto> GetVulneraciones(TipoVulneracionIdDto tipoVulneracionId);
    }
}