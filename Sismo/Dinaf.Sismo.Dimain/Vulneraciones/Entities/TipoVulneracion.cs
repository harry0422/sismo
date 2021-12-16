using Dinaf.Sismo.Domain.Common.Entities;

namespace Dinaf.Sismo.Domain.Vulneraciones.Entities
{
    public class TipoVulneracion : EntityBase<int>
    {
        public virtual string Tipologia { get; set; }
        public virtual string Artuculo { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}