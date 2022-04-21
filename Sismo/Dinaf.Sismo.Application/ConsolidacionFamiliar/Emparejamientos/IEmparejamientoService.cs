using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos
{
    public interface IEmparejamientoService
    {
        public List<PreEmparejamientoDto> ObtenerNnaParaPreEmparejamiento(NumeroSolicitudDto numeroSolicitud);
        public List<PreEmparejamientoDto> ObtenerSolicitantesParaPreEmparejamiento(NumeroExpedienteNnaDto numeroExpediente);
        public void CrearPreEmparejamiento(NuevoEmparejamientoDto dto);
        public void CrearAvanzarEtapa(InformacionSeguimientoDto dto);
    }
}