using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Entities
{
    public class CondicionMedica : EntityBase<int>, IAggregateRoot
    {
        public virtual string Descripcion { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}