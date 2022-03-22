namespace Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs
{
    public class ExpedienteDto
    {
        public int Id { get; set; }
        public string NumeroExpediente { get; set; }
        public string FechaCreacion { get; set; }
        public string Unidad { get; set; }
        public int Usuario { get; set; }
        public string TipoInstrumento { get; set; }
        public string UnidadApertura { get; set; }
        public string NumeroAnterior { get; set; }
        public string Estado { get; set; }
        public string UsusarioAsignado { get; set; }
    }
}
