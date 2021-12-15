using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Personas.Entities
{
    public class PersonaExpediente : EntityBase<int>, IAggregateRoot
    {
        public virtual Persona Persona { get; set; }
        public virtual string NumeroExpediente { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Encalidad { get; set; }
        public virtual string ExpNna { get; set; }
        public virtual string Estado { get; set; }
        public virtual DateTime FechaEstado { get; set; }
        public virtual string ClaveTemporal { get; set; }
        public virtual string Asunto { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}