namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs
{
    public  class PreEmparejamientoSolicitudDto
    {
        public string NumeroExpediente { get; set; }
        public string Nombres { get; set; }
        public string FechaCreacion { get; set; }
        public string TipoInstrumento { get; set; }
        public string TipoSolicitud { get; set; }
        public decimal PorcetajeCoincidencia { get; set; }
    }
}