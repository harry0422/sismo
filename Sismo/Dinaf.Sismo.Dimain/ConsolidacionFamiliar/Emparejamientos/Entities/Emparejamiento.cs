using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities
{
    public class Emparejamiento : EntityBase<string>
    {
        public Emparejamiento() { }

        public Emparejamiento(string expedienteNna, string solicitudAdopcion)
        {
            Id = Guid.NewGuid().ToString();
            EtapaActual = Etapa.PreEmparejamiento;
            ExpedienteNna = expedienteNna;
            SolicitudAdopcion = solicitudAdopcion;
            Seguimientos = new List<DetalleSeguimiento>();
        }

        public virtual Etapa EtapaActual { get; set; }
        public virtual string ExpedienteNna { get; set; }
        public virtual string SolicitudAdopcion { get; set; }
        public virtual IList<DetalleSeguimiento> Seguimientos { get; set; }

        public virtual Etapa SiguienteEtapa
        {
            get { return (Etapa)(int)EtapaActual + 1; }
        }

        public virtual void AvanzarEtapa()
        {
            EtapaActual = SiguienteEtapa;
        }

        public virtual void AgregarSeguimiento( DateTime? fecha, string observaciones, string usuario, bool tieneAdjunto)
        {
            AvanzarEtapa();
            DetalleSeguimiento detalleSeguimiento = new DetalleSeguimiento(this, EtapaActual, fecha, observaciones, usuario, tieneAdjunto);
            Seguimientos.Add(detalleSeguimiento);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}