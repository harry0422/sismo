using Dinaf.Sismo.Domain.Common.Entities;
using System;

//TODO: Revisar si este namespace es el adecuado
namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class ExpedienteNna : EntityBase<int>, IAggregateRoot
    {
        public virtual string NumeroExpediente { get; set; }
        public virtual DateTime FechaCreacion { get; set; }
        public virtual DetalleNna DetalleNna { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}