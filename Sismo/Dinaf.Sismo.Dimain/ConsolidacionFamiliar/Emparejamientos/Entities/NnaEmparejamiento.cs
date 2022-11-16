using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities
{
    public class NnaEmparejamiento : EntityBase<string>, IAggregateRoot
    {
        public virtual string NumeroExpediente
        {
            get { return Id; }
        }



        public virtual IList<Emparejamiento> Emparejamientos { get; set; }

        //TODO: Get boolean value if it has attached file 
        public virtual void AgregarEmparejamiento(string solicitudAdopcion, DateTime? fecha, string observaciones, string usuario)
        {
            Emparejamiento emparejamiento = new Emparejamiento(NumeroExpediente, solicitudAdopcion);
            emparejamiento.AgregarSeguimiento(fecha, observaciones, usuario, true);
        }

        public virtual Emparejamiento ObtenerEmparejamientoPorId(string id)
        {
            return Emparejamientos.Where(x => x.Id == id).FirstOrDefault();
        }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}