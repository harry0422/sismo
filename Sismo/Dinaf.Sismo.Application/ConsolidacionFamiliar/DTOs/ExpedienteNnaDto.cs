using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs
{
    public class ExpedienteNnaDto
    {
        public ExpedienteNnaDto()
        {
            Vulneraciones = new List<VulneracionDto>();
            MedidasProteccion = new List<MedidaProteccionDto>();
        }

        public string NumeroExpediente { get; set; }
        public string FechaCreacion { get; set; }
        public DetalleNnaDto DetalleNna { get; set; }
        public List<VulneracionDto> Vulneraciones { get; set; }
        public List<MedidaProteccionDto> MedidasProteccion { get; set; }
    }
}