using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class ExpedienteNna : EntityBase<string>, IAggregateRoot
    {
        public virtual DateTime FechaCreacion { get; set; }
        public virtual DetalleNna DetalleNna { get; set; }

        public virtual string NumeroExpediente
        {
            get { return Id; }
        }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}