using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities
{
    public class DetallePersona : EntityBase<int>, IAggregateRoot
    {
        public DetallePersona() { }

        public DetallePersona(Nombre nombre, string genero, string nna, string raza, string religion, DateTime fechaNacimiento, string nacionalidad, int usuario, string colorCabello, string colorOjos, string colorPiel, string signosFisicos, string ocupacion, string observaciones, IList<Relacion> relaciones)
        {
            Nombre.Add(nombre);
            Genero = genero;
            Nna = nna;
            Raza = raza;
            Religion = religion;
            FechaNacimiento = fechaNacimiento;
            Nacionalidad = nacionalidad;
            Usuario = usuario;
            ColorCabello = colorCabello;
            ColorOjos = colorOjos;
            ColorPiel = colorPiel;
            SignosFisicos = signosFisicos;
            Ocupacion = ocupacion;
            Observaciones = observaciones;
            Relaciones = relaciones;
        }

        public virtual IList<Nombre> Nombre { get; set; }
        public virtual string Genero { get; set; }
        public virtual string Nna { get; set; }
        public virtual string Raza { get; set; }
        public virtual string Religion { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        public virtual string Nacionalidad { get; set; }
        public virtual int Usuario { get; set; }
        public virtual string ColorCabello { get; set; }
        public virtual string ColorOjos { get; set; }
        public virtual string ColorPiel { get; set; }
        public virtual string SignosFisicos { get; set; }
        public virtual string Ocupacion { get; set; }
        public virtual string Observaciones { get; set; }
        public virtual IList<Relacion> Relaciones { get; set; }

        public virtual string NombreCorto
        {
            get
            {
                if (Nombre is null || Nombre.Count == 0) return string.Empty;

                return $"{Nombre.First().PrimerNombre} {Nombre.First().PrimerApellido}";
            }
        }

        public virtual string NombreCompleto
        {
            get
            {
                if (Nombre is null) return string.Empty;

                return $"{Nombre.First().PrimerNombre} {Nombre.First().SegundoNombre} {Nombre.First().PrimerApellido} {Nombre.First().SegundoApellido}";
            }
        }

        public virtual int Edad
        {
            get
            {
                return DateTime.Now.AddYears(-FechaNacimiento.Year).Year;
            }
        }

        public virtual Relacion ObtenerRelacionParaInstrumento(string correlativoInstrumento)
        {
            return Relaciones
                .Where(x => x.CorrelativoInstrumento == correlativoInstrumento)
                .FirstOrDefault();
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}