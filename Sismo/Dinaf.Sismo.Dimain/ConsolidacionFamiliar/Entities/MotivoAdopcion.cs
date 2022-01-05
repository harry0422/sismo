using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class MotivoAdopcion : EntityBase<int>, IAggregateRoot
    {
        public virtual DateTime FechaCreacion { get; set; }
        public virtual string Contenido { get; set; }
        public virtual string NumeroExpediente { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}