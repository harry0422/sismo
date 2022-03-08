using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common
{
    public class TipoParentesco : EntityBase<int>
    {
        public virtual string Descripcion { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}