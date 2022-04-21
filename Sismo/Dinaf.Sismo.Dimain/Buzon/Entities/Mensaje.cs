using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Buzon.Entities
{
    public class Mensaje : EntityBase<int>, IAggregateRoot
    {
        private const string TIPO_PREDETERMINADO = "own";

        public Mensaje() { }

        public Mensaje(string asunto, string contenido, Caso caso)
        {
            FechaCreacion = DateTime.Now;
            Remitente = caso.UsuarioApertura;
            Asunto = asunto;
            Contenido = contenido;
            Caso = caso;
            Tipo = TIPO_PREDETERMINADO;
            UnidadDestino = caso.UnidadDestino;
            UnidadRemitente = caso.UnidadApertura;
        }

        public virtual DateTime FechaCreacion { get; set; }
        public virtual DateTime? FechaLeido { get; set; }
        public virtual int Remitente { get; set; }
        public virtual string Asunto { get; set; }
        public virtual string Contenido { get; set; }
        public virtual Caso Caso { get; set; }
        public virtual string Tipo { get; set; }
        public virtual int UnidadDestino { get; set; }
        public virtual int UnidadRemitente { get; set; }

        public virtual bool Leido
        {
            get { return (FechaLeido != null); }
        }

        public virtual void MarcarComoLeido()
        {
            FechaLeido = DateTime.Now;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}