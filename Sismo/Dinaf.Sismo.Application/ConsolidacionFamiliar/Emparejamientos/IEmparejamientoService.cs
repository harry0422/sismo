using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos
{
    public interface IEmparejamientoService
    {
        public IList<PreEmparejamientoNnaDto> ObtenerNnaParaPreEmparejamiento(NumeroSolicitudDto numeroSolicitud);
        public IList<PreEmparejamientoSolicitudDto> ObtenerSolicitantesParaPreEmparejamiento(NumeroExpedienteNnaDto numeroExpediente);
        public IList<NnaEmparejamientoDto> ObtenerEmparejamientos();
        public NnaEmparejamientoDto ObtenerDetalleEmparejamiento(NumeroExpedienteNnaDto numeroExpediente);
        public void CrearPreEmparejamiento(NuevoEmparejamientoDto dto);
        public void CrearAvanzarEtapa(InformacionSeguimientoDto dto);
        public IList<SeguimientoDto> ObtenerSeguimientos();
        public IList<SeguimientoDto> ObtenerSeguimientos(EmparejamientoIdDto emparejamientoId);
    }
}