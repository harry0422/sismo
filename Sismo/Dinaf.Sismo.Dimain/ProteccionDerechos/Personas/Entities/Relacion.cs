using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities
{
    public class Relacion : EntityBase<int>
    {
        public virtual TipoParentesco TipoParentesco { get; set; }
        public virtual string Estado { get; set; }
        public virtual string CorrelativoInstrumento { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}