using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class SolicitudAdopcion : EntityBase<string>, IAggregateRoot
    {
        public virtual DateTime FechaCreacion { get; set; }
        public virtual string TipoInstrumento { get; set; }
        public virtual string Estado { get; set; }
        public virtual string Procedencia { get; set; }
        public virtual IList<MotivoAdopcion> MotivosAdopcion { get; set; }
        public virtual IList<Solicitante> Solicitantes { get; set; }

        public virtual string NumeroExpediente
        {
            get { return Id; }
        }

        public virtual string TipoSolicitud
        {
            get { return SolicitantesAdopcion.Count == 1 ? "Monoparental" : "Biparental"; }
        }

        public virtual IList<DetalleSolicitante> SolicitantesAdopcion
        {
            get { return Solicitantes.Where(x => x.EsSolicitanteAdopcion).Select(x => x.DetalleSolicitante).ToList(); }
        }

        public virtual DetalleSolicitante RepresentanteLegal
        {
            get 
            {
                Solicitante representanteLegal = Solicitantes.FirstOrDefault(x => x.EsRepresentanteLegal);
                return representanteLegal is null ? null : representanteLegal.DetalleSolicitante; 
            }
        }

        
        public virtual string DescripcionMotivoAdopcion
        {
            get { return string.Join(" ", MotivosAdopcion.Select(x => x.Contenido)); }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}