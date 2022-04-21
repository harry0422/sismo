using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities
{
    public class DetalleSeguimiento : EntityBase<string>
    {
        public DetalleSeguimiento() { }

        public DetalleSeguimiento(Etapa etapa, DateTime? fecha, string observaciones, string usuario)
        {
            Etapa = etapa;
            Fecha = fecha ?? DateTime.Now;
            Observaciones = observaciones;
            Usuario = usuario;
        }

        public virtual Etapa Etapa { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Observaciones { get; set; }
        public virtual string Usuario { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}