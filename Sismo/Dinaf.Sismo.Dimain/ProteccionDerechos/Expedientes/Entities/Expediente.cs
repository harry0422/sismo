using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes
{
    public class Expediente : EntityBase<int>, IAggregateRoot
    {
        public virtual string NumeroExpediente { get; set; }
        public virtual DateTime FechaCreacion { get; set; }
        public virtual int Unidad { get; set; }
        public virtual int Usuario { get; set; }
        public virtual string TipoInstrumento { get; set; }
        public virtual int UnidadApertura { get; set; }
        public virtual string NumeroAnterior { get; set; }
        public virtual string Estado { get; set; }
        public virtual string UsusarioAsignado { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
