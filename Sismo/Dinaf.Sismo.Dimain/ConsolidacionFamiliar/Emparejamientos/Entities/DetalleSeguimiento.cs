using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities
{
    public class DetalleSeguimiento : EntityBase<string>, IAggregateRoot
    {
        public DetalleSeguimiento() { }

        public DetalleSeguimiento(Emparejamiento emparejamiento, Etapa etapa, DateTime? fecha, string observaciones, string usuario, bool adjunto)
        {
            Id = Guid.NewGuid().ToString();
            Emparejamiento = emparejamiento;
            Etapa = etapa;
            Fecha = fecha ?? DateTime.Now;
            Observaciones = observaciones;
            Usuario = usuario;
            Adjunto = adjunto;
        }

        public virtual Emparejamiento Emparejamiento { get; set; }
        public virtual Etapa Etapa { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Observaciones { get; set; }
        public virtual string Usuario { get; set; }
        public virtual bool Adjunto { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}