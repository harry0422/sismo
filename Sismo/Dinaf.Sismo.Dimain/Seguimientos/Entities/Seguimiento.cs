using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Seguimientos.Entities
{
    public class Seguimiento : EntityBase<int>, IAggregateRoot
    {
        public virtual string NumeroExpediente { get; set; }
        public virtual TipoCustodio TipoCustodio { get; set; }
        public virtual DateTime FechaInicio { get; set; }
        public virtual DateTime FechaFinal { get; set; }
        public virtual string Referencias { get; set; }
        public virtual int UsuarioRemitente { get; set; }
        public virtual string TipoGestion { get; set; }
        public virtual string Estado { get; set; }
        public virtual string UnidadRemitente { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
