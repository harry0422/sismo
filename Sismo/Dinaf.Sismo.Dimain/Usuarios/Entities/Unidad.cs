using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Usuarios.Entities
{
    public class Unidad : EntityBase<int>, IAggregateRoot
    {
        public virtual string Descripcion { get; set; }
        public virtual int Centro { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string EstadoUnidad { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}