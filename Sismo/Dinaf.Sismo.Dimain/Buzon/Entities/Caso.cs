using Dinaf.Sismo.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Buzon.Entities
{
    public class Caso : EntityBase<int>, IAggregateRoot
    {
        private const string ESTADO_CERRADO = "close";
        private const string ESTADO_ABIERTO = "open";

        public Caso() { }

        public Caso(Usuario usuarioApertura, TipoGestion tipoGestion, string numeroInstrumento, Usuario usuarioAsignado)
        {
            UsuarioApertura = usuarioApertura.UsuarioId;
            UnidadApertura = usuarioApertura.Unidad;
            Estado = ESTADO_ABIERTO;
            TipoGestion = tipoGestion;
            NumeroInstrumento = numeroInstrumento;
            FechaCreacion = DateTime.Now;
            UnidadDestino = usuarioAsignado.UsuarioId;
            UsuarioAsignado = usuarioAsignado.UsuarioId;
        }

        public virtual int UsuarioApertura { get; set; }
        public virtual int UnidadApertura { get; set; }
        public virtual string Estado { get; set; }
        public virtual TipoGestion TipoGestion { get; set; }
        public virtual string NumeroInstrumento { get; set; }
        public virtual DateTime FechaCreacion { get; set; }
        public virtual int UnidadDestino { get; set; }
        public virtual int UsuarioAsignado { get; set; }
        public virtual IList<Mensaje> Mensajes { get; set; }

        public virtual void AgregarMensaje(string asunto, string contenido)
        {
            Mensaje mensaje = new Mensaje(asunto, contenido, this);
            Mensajes.Add(mensaje);
        }

        public virtual void CerrarCaso()
        {
            Estado = ESTADO_CERRADO;
        }

        //TODO: Implementar de ser necesario, sino borrar
        public virtual void AsignarUsuario(string usuarioAsignado, TipoGestion tipoGestion)
        {
            throw new NotImplementedException();
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}