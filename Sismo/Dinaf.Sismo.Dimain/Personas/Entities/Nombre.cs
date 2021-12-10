using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Personas.Entities
{
    public class Nombre : EntityBase<int>
    {
        public virtual TipoNombre TipoNombre { get; set; }
        public virtual string PrimerNombre { get; set; }
        public virtual string SegundoNombre { get; set; }
        public virtual string PrimerApellido { get; set; }
        public virtual string SegundoApellido { get; set; }
        public virtual string CorrelativoInstrumento { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual string NombreCompleto { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}