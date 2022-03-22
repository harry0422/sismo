namespace Dinaf.Sismo.Application.ProteccionDerechos.MedidasProteccion.DTOs
{
    public class MedidaProteccionDto
    {
        public int Id { get; set; }
        public string NumeroExpediente { get; set; }
        public string TipoCustodio { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Referencias { get; set; }
        public int UsuarioRemitente { get; set; }
        public string TipoGestion { get; set; }
        public string Estado { get; set; }
        public string UnidadRemitente { get; set; }
    }
}