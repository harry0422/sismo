using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class CaracteristicasSolicitud : EntityBase<string>
    {
        public CaracteristicasSolicitud() { }

        public CaracteristicasSolicitud(string numeroExpediente, string genero, int edadMinima, int edadMaxima, int condicionMedica, int cantidadHermanos)
        {
            Id = numeroExpediente;
            Genero = genero;
            EdadMinima = edadMinima;
            EdadMaxima = edadMaxima;
            CondicionMedica = condicionMedica;
            CantidadHermanos = cantidadHermanos;
        }
        
        public virtual string Genero { get; set; }
        public virtual int EdadMinima { get; set; }
        public virtual int EdadMaxima { get; set; }
        public virtual int CondicionMedica { get; set; }
        public virtual int CantidadHermanos { get; set; }

        public virtual string NumeroExpediente
        {
            get { return Id; }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}