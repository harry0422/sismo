using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.MedidasProteccion.Entities
{
    public class MedidaProteccion : EntityBase<int>, IAggregateRoot
    {
        private const string ESTADO_ON = "ON";
        private const string ESTADO_OFF = "OFF";

        public MedidaProteccion() { }

        public MedidaProteccion(string numeroExpediente, TipoCustodio tipoCustodio, string referencias, int usuarioRemitente, string tipoGestion, string unidadRemitente)
        {
            NumeroExpediente = numeroExpediente;
            TipoCustodio = tipoCustodio;
            FechaInicio = DateTime.Now;
            Referencias = referencias;
            UsuarioRemitente = usuarioRemitente;
            TipoGestion = tipoGestion;
            Estado = ESTADO_ON;
            UnidadRemitente = unidadRemitente;
        }

        public virtual string NumeroExpediente { get; set; }
        public virtual TipoCustodio TipoCustodio { get; set; }
        public virtual DateTime FechaInicio { get; set; }
        public virtual DateTime FechaFinal { get; set; }
        public virtual string Referencias { get; set; }
        public virtual int UsuarioRemitente { get; set; }
        public virtual string TipoGestion { get; set; }
        public virtual string Estado { get; set; }
        public virtual string UnidadRemitente { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
