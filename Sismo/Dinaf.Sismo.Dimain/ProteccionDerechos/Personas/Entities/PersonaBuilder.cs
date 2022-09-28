using System;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities
{
    public class PersonaBuilder
    {
        private DetallePersona detallePersona;

        public PersonaBuilder ConNombre(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            Nombre nombre = new Nombre(primerNombre, segundoNombre, primerApellido, segundoApellido);
            detallePersona.AgregarNombre(nombre);
            
            return this;
        }

        public PersonaBuilder ConDatosGenerales(string genero, string fechaNacimiento, string nacionalidad)
        {
            detallePersona.Genero = genero;
            detallePersona.FechaNacimiento = DateTime.Parse(fechaNacimiento);
            detallePersona.Nacionalidad = nacionalidad;

            return this;
        }

        public PersonaBuilder ConDatosAdicionales(string raza, string religion, string ocupacion)
        {
            detallePersona.Raza = raza;
            detallePersona.Religion = religion;
            detallePersona.Ocupacion = ocupacion;

            return this;
        }

        public PersonaBuilder ConCaracteristicasFisicas(string colorCabello, string colorOjos, string colorPiel, string signosFisicos)
        {
            detallePersona.ColorCabello = colorCabello;
            detallePersona.ColorOjos = colorOjos;
            detallePersona.ColorPiel = colorPiel;
            detallePersona.SignosFisicos = signosFisicos;
            
            return this;
        }

        public PersonaBuilder ConObservaciones(string observaciones)
        {
            detallePersona.Observaciones = observaciones;
            return this;
        }

        public PersonaBuilder ConUsuarioCreacion(int usuarioCreacion)
        {
            detallePersona.Usuario = usuarioCreacion;
            return this;
        }

        public PersonaBuilder ConNna(string nna)
        {
            detallePersona.Nna = nna;
            return this;
        }

        public DetallePersona ObtenerInstancia()
        {
            return detallePersona;
        }
    }
}