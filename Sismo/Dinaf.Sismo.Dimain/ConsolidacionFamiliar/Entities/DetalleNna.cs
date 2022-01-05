﻿using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class DetalleNna : EntityBase<int>, IAggregateRoot
    {
        public virtual IList<Nombre> Nombres { get; set; }
        public virtual string Genero { get; set; }
        public virtual string Raza { get; set; }
        public virtual string Religion { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        public virtual string Nacionalidad { get; set; }
        public virtual string ColorCabello { get; set; }
        public virtual string ColorOjos { get; set; }
        public virtual string ColorPiel { get; set; }
        public virtual string SignosFisicos { get; set; }
        public virtual string Ocupacion { get; set; }
        public virtual IList<Relacion> Relaciones { get; set; }

        public virtual string NombreCorto
        {
            get
            {
                if (!Nombres.Any()) return string.Empty;
                Nombre nombre = Nombres.FirstOrDefault();

                return $"{nombre.PrimerNombre} {nombre.PrimerApellido}";
            }
        }

        public virtual string NombreCompleto
        {
            get
            {
                if (!Nombres.Any()) return string.Empty;
                Nombre nombre = Nombres.FirstOrDefault();

                return $"{nombre.PrimerNombre} {nombre.SegundoNombre} {nombre.PrimerApellido} {nombre.SegundoApellido}";
            }
        }

        public virtual int Edad
        {
            get { return DateTime.Now.AddYears(-FechaNacimiento.Year).Year; }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}