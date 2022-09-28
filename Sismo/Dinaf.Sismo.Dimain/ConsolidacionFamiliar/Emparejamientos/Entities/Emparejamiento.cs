using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities
{
    public class Emparejamiento : EntityBase<string>, IAggregateRoot
    {
        public Emparejamiento() { }

        public Emparejamiento(string expedienteNna, string solicitudAdopcion)
        {
            Id = Guid.NewGuid().ToString();
            Etapa = Etapa.PreEmparejamiento;
            ExpedienteNna = expedienteNna;
            SolicitudAdopcion = solicitudAdopcion;
            Seguimientos = new List<DetalleSeguimiento>();
        }

        public virtual Etapa Etapa { get; set; }
        public virtual string ExpedienteNna { get; set; }
        public virtual string SolicitudAdopcion { get; set; }
        public virtual IList<DetalleSeguimiento> Seguimientos { get; set; }

        public virtual void AgregarSeguimiento(Etapa etapa, DateTime? fecha, string observaciones, string usuario)
        {
            DetalleSeguimiento detalleSeguimiento = new DetalleSeguimiento(this, etapa, fecha, observaciones, usuario);
            Seguimientos.Add(detalleSeguimiento);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}