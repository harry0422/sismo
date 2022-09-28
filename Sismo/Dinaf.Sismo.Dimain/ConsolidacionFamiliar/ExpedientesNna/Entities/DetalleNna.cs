using Dinaf.Sismo.Domain.Common.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities
{
    public class DetalleNna : EntityBase<int>, IAggregateRoot
    {
        public virtual IList<NombreSolicitante> Nombres { get; set; }
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
        public virtual string CondicionMedica { get; set; }
        public virtual string FotoPerfil { get; set; }
        public virtual IList<RelacionSolicitante> Relaciones { get; set; }

        public virtual NombreSolicitante Nombre
        {
            get { return Nombres.FirstOrDefault(); }
        }


        public virtual string NombreCorto
        {
            get
            {
                return (Nombre is null) ? string.Empty : $"{Nombre.PrimerNombre} {Nombre.PrimerApellido}";
            }
        }

        public virtual string NombreCompleto
        {
            get
            {
                return (Nombre is null) ? string.Empty :
                    $"{Nombre.PrimerNombre} {Nombre.SegundoNombre} {Nombre.PrimerApellido} {Nombre.SegundoApellido}";
            }
        }

        public virtual int Edad
        {
            get 
            {
                int edad = DateTime.Now.AddYears(-FechaNacimiento.Year).Year;
                return edad <= 100 ? edad : 0; 
            }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}