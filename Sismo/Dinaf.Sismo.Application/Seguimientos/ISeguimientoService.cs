using Dinaf.Sismo.Application.Seguimientos.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Seguimientos
{
    public interface ISeguimientoService
    {
        List<SeguimientoDto> GetMedidasProteccion(NumeroExpedienteDto numeroExpediente);
    }
}