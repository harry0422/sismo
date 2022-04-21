using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common
{
    public class DetalleSolicitante : EntityBase<int>
    {
        public virtual NombreSolicitante Nombre { get; set; }
        public virtual string Genero { get; set; }
        public virtual string Estado { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        public virtual string Nacionalidad { get; set; }
        public virtual string Ocupacion { get; set; }
        public virtual string Observaciones { get; set; }
        public virtual IList<RelacionSolicitante> Relaciones { get; set; }

        public virtual string NombreCorto
        {
            get
            {
                if (Nombre is null) return string.Empty;

                return $"{Nombre.PrimerNombre} {Nombre.PrimerApellido}";
            }
        }

        public virtual string NombreCompleto
        {
            get
            {
                if (Nombre is null) return string.Empty;

                return $"{Nombre.PrimerNombre} {Nombre.SegundoNombre} {Nombre.PrimerApellido} {Nombre.SegundoApellido}";
            }
        }

        public virtual int Edad
        {
            get
            {
                return DateTime.Now.AddYears(-FechaNacimiento.Year).Year;
            }
        }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}