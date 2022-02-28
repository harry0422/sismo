using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities
{
    public class Emparejamiento : EntityBase<string>, IAggregateRoot
    {
        public Emparejamiento() { }

        public Emparejamiento(string expedienteNna, string solicitudAdopcion, DetalleSeguimiento detalleSeguimiento)
        {
            Etapa = Etapa.PreEmparejamiento;
            ExpedienteNna = expedienteNna;
            SolicitudAdopcion = solicitudAdopcion;
            Seguimientos = new List<DetalleSeguimiento>() { detalleSeguimiento };
        }

        public virtual Etapa Etapa { get; set; }
        public virtual string ExpedienteNna { get; set; }
        public virtual string SolicitudAdopcion { get; set; }
        public virtual IList<DetalleSeguimiento> Seguimientos { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}