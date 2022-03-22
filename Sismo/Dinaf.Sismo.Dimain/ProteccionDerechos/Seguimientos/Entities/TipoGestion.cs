namespace Dinaf.Sismo.Domain.ProteccionDerechos.Seguimientos.Entities
{
    public static class TipoGestion
    {
        public static string Ingreso { get; } = "Ingreso";
        public static string Egreso { get; } = "Egreso";
        public static string Evasion { get; } = "Evasión";
        public static string Remision { get; } = "Remisión";
        public static string CumplimientoPlazo { get; } = "Cumplimiento de Plazo";
        public static string ActaCompromiso { get; } = "Acta y Compromiso";
        public static string EntregaCompromiso { get; } = "Entrega y Compromiso";
    }
}