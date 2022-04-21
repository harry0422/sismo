using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities
{
    public class ParametroEmparejamiento : EntityBase<int>, IAggregateRoot
    {
        public ParametroEmparejamiento() { }

        public ParametroEmparejamiento(string nombre, decimal valor, int usuario)
        {
            Nombre = nombre;
            Valor = valor;
            Usuario = usuario;
            Fecha = DateTime.Now;
        }

        public virtual string Nombre { get; set; }
        public virtual decimal Valor { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual int Usuario { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}