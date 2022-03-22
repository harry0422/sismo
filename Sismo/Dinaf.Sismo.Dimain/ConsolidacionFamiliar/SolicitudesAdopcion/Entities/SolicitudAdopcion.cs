using Dinaf.Sismo.Domain.Common.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
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
        public virtual CaracteristicasSolicitud CaracteristicasSolicitud { get; set; }
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

        public virtual bool PuedeEmparejar
        {
            get { return !(CaracteristicasSolicitud is null); }
        }

        public virtual IList<DetalleSolicitante> SolicitantesAdopcion
        {
            get { return Solicitantes.Where(x => x.EsSolicitanteAdopcion).Select(x => x.DetallePersona).ToList(); }
        }

        public virtual DetalleSolicitante RepresentanteLegal
        {
            get 
            {
                Solicitante representanteLegal = Solicitantes.FirstOrDefault(x => x.EsRepresentanteLegal);
                return representanteLegal is null ? null : representanteLegal.DetallePersona; 
            }
        }
        
        public virtual string DescripcionMotivoAdopcion
        {
            get { return string.Join(" ", MotivosAdopcion.Select(x => x.Contenido)); }
        }

        public virtual void AgregarCaracteristicas(string genero, int edadMinima, int edadMaxima, int condicionMedica, int cantidadHermanos)
        {
            CaracteristicasSolicitud = new CaracteristicasSolicitud(NumeroExpediente, genero, edadMinima, edadMaxima, condicionMedica, cantidadHermanos);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}