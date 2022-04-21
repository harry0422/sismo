using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class CaracteristicasAdopcion : EntityBase<string>
    {
        public CaracteristicasAdopcion() { }

        public CaracteristicasAdopcion(string numeroExpediente, string genero, int edadMinima, int edadMaxima, int condicionMedica, int cantidadHermanos)
        {
            Id = Guid.NewGuid().ToString();
            NumeroExpediente = numeroExpediente;
            Genero = genero;
            EdadMinima = edadMinima;
            EdadMaxima = edadMaxima;
            CondicionMedica = condicionMedica;
            CantidadHermanos = cantidadHermanos;
            FechaCreacion = DateTime.Now;
        }

        public virtual string NumeroExpediente { get; set; }
        public virtual string Genero { get; set; }
        public virtual int EdadMinima { get; set; }
        public virtual int EdadMaxima { get; set; }
        public virtual int CondicionMedica { get; set; }
        public virtual int CantidadHermanos { get; set; }
        public virtual DateTime FechaCreacion { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}