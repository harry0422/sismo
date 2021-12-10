using Dinaf.Sismo.Domain.Common.Entities;

namespace Dinaf.Sismo.Domain.Personas.Entities
{
    public class TipoNombre : EntityBase<int>
    {
        public virtual string Valor { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}