using Dinaf.Sismo.Domain.Common.Entities;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities
{
    public class Nombre : EntityBase<int>
    {
        public Nombre() { }

        public Nombre(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
        }

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