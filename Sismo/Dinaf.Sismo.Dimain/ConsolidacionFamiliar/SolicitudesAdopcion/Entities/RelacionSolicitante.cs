using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common
{
    public class RelacionSolicitante : EntityBase<int>
    {
        public virtual ParentescoSolicitante TipoParentesco { get; set; }
        public virtual string Estado { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}