using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Linq;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common
{
    public class Persona : EntityBase<int>, IAggregateRoot
    {
        private const int ID_SOLICITANTE_ADOPCION = 32;
        private const int ID_REPRESENTANTE_LEGAL = 33;

        public virtual DetallePersona DetallePersona { get; set; }
        public virtual string NumeroExpediente { get; set; }
        public virtual DateTime Fecha { get; set; }

        public virtual bool EsSolicitanteAdopcion
        {
            get { return DetallePersona.Relaciones.First().TipoParentesco.Id == ID_SOLICITANTE_ADOPCION; }
        }

        public virtual bool EsRepresentanteLegal
        {
            get { return DetallePersona.Relaciones.First().TipoParentesco.Id == ID_REPRESENTANTE_LEGAL; }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}