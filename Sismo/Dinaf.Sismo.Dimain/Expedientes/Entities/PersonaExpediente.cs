using Dinaf.Sismo.Domain.Common.Entities;
using Dinaf.Sismo.Domain.Personas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Domain.Expedientes.Entities
{
    public class PersonaExpediente : EntityBase<int>
    {
        public virtual Persona Persona { get; set; }
        public virtual Expediente Expediente { get; set; }
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
