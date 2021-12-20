using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Vulneraciones.Entities
{
    public class Vulneracion : EntityBase<int>, IAggregateRoot
    {
        public virtual DateTime FechaCreacion { get; set; }
        public virtual int UsuarioRemitente { get; set; }
        public virtual string NumeroInstrumento { get; set; }
        public virtual SubTipoVulneracion  SubTipoVulneracion { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}