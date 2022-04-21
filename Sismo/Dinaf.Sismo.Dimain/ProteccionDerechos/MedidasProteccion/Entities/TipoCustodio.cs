using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.MedidasProteccion.Entities
{
    public class TipoCustodio : EntityBase<int>
    {
        public virtual string Nombre { get; set; }
        public virtual string Descripcion { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}