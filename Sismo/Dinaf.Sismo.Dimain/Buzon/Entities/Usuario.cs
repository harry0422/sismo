using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Buzon.Entities
{
    public class Usuario : ValueObjectBase
    {
        public int UsuarioId { get; set; }
        public int Unidad { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}