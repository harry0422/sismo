using Dinaf.Sismo.Application.ProteccionDerechos.MedidasProteccion.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.MedidasProteccion
{
    public interface IMedidaProteccionService
    {
        List<MedidaProteccionDto> GetMedidasProteccion(NumeroExpedienteDto numeroExpediente);
        void AgregarMedidaProteccion(NuevaMedidaProteccionDto nuevaMedidaProteccion);
    }
}