using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Dimain.Expedientes
{
    public class Expediente
    {
        public int Id { get; set; }
        public string NumeroExpediente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Unidad Unidad { get; set; }
        public int Usuario { get; set; }
        public string TipoInstrumento { get; set; }
        public Unidad UnidadApertura { get; set; }
        public string Tipo { get; set; }
        public string NumeroAnterior { get; set; }
        public string Estado { get; set; }
        public string AñoAnterior { get; set; }
        public string Procedencia { get; set; }
        public int Consentimiento { get; set; }
        public string Cf { get; set; }
        public int UsuarioAsignado { get; set; }
        public DateTime SFecha { get; set; }
        public string Issue { get; set; }
        public DateTime FechaVulneracion { get; set; }

        public IList<Convenio> Convenios { get; set; }

    }
}
