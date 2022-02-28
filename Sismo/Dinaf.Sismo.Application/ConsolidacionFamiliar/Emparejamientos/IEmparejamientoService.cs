using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos
{
    public interface IEmparejamientoService
    {
        public List<PreEmparejamientoDto> ObtenerNnaPreEmparejamiento(NumeroExpedienteDto numeroExpediente);
        public List<PreEmparejamientoDto> ObtenerSolicitudPreEmparejamiento(NumeroExpedienteDto numeroExpediente);
        public void CrearPreEmparejamiento(NuevoEmparejamientoDto dto);
        public void CrearAvanzarEtapa(InformacionSeguimientoDto dto);
    }
}