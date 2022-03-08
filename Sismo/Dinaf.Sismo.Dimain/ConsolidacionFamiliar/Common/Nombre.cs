using Dinaf.Sismo.Domain.Common.Entities;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common
{
    public class Nombre : EntityBase<int>
    {
        public virtual string PrimerNombre { get; set; }
        public virtual string SegundoNombre { get; set; }
        public virtual string PrimerApellido { get; set; }
        public virtual string SegundoApellido { get; set; }
        

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
