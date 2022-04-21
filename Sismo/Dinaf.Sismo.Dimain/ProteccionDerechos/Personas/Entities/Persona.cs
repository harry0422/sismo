using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities
{
    public class Persona : EntityBase<int>, IAggregateRoot
    {
        public Persona() { }

        public Persona(DetallePersona detallePersona, string numeroExpediente, int usuarioCreacion, string enCalidad)
        {
            DetallePersona = detallePersona;
            NumeroExpediente = numeroExpediente;
            UsuarioCreacion = usuarioCreacion;
            FechCreaciona = DateTime.Now;
            EnCalidad = enCalidad;
            Nna = detallePersona.Nna == "nna" ? "nna" : null;
        }

        public virtual DetallePersona DetallePersona { get; set; }
        public virtual string NumeroExpediente { get; set; }
        public virtual int UsuarioCreacion { get; set; }
        public virtual DateTime FechCreaciona { get; set; }
        public virtual string EnCalidad { get; set; }
        public virtual string Nna { get; set; }

        public virtual bool EsNna
        {
            get { return !(Nna is null); }
        }

        public virtual bool EsFamiliar
        {
            get { return Nna is null; }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}