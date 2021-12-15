using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Expedientes.Entities
{
    public class Expediente : EntityBase<int>, IAggregateRoot
    {
        public virtual string NumeroExpediente { get; set; }
        public virtual DateTime FechaCreacion { get; set; }
        public virtual Unidad Unidad { get; set; }
        public virtual int Usuario { get; set; }
        public virtual string TipoInstrumento { get; set; }
        public virtual Unidad UnidadApertura { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string NumeroAnterior { get; set; }
        public virtual string Estado { get; set; }
        public virtual string AñoAnterior { get; set; }
        public virtual string Procedencia { get; set; }
        public virtual int Consentimiento { get; set; }
        public virtual string Cf { get; set; }
        public virtual int UsuarioAsignado { get; set; }
        public virtual DateTime SFecha { get; set; }
        public virtual string Issue { get; set; }
        public virtual DateTime FechaVulneracion { get; set; }

        public virtual IList<Convenio> Convenios { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
