using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Vulneraciones.Entities
{
    public class SubTipoVulneracion : EntityBase<int>
    {
        public virtual TipoVulneracion TipoVulneracion { get; set; }
        public virtual string Tipologia { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}