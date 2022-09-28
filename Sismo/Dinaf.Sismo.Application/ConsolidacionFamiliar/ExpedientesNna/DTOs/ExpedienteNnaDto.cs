namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs
{
    public class ExpedienteNnaDto
    {
        public int Id { get; set; }
        public string NumeroExpediente { get; set; }
        public string FechaCreacion { get; set; }
        public DetalleNnaDto DetalleNna { get; set; }
    }
}