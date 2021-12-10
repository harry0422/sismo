namespace Dinaf.Sismo.Application.Expedientes.DTOs
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
        public string Tipo { get; set; }
        public string NumeroAnterior { get; set; }
        public string Estado { get; set; }
        public string AñoAnterior { get; set; }
        public string Procedencia { get; set; }
        public int Consentimiento { get; set; }
        public string Cf { get; set; }
        public int UsuarioAsignado { get; set; }
        public string SFecha { get; set; }
        public string Issue { get; set; }
        public string FechaVulneracion { get; set; }
    }
}
