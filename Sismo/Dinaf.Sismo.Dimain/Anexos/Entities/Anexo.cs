using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Anexos.Entities
{
    public class Anexo : EntityBase<int>, IAggregateRoot
    {
        public virtual DateTime FechaCreacion { get; set; }
        public virtual string Asunto { get; set; }
        public virtual string Contenido { get; set; }
        public virtual string UsuarioRemitente { get; set; }
        public virtual string NumeroExpediente { get; set; }
        public virtual string Responsable { get; set; }
        public virtual int UnidadRemitente { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}