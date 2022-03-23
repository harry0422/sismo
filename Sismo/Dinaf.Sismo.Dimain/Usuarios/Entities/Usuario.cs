using Dinaf.Sismo.Domain.Common.Entities;
using System;

namespace Dinaf.Sismo.Domain.Usuarios.Entities
{
    public class Usuario : EntityBase<int>, IAggregateRoot
    {
        public virtual string Nombre { get; set; }
        public virtual int Perfil { get; set; }
        public virtual string NombreUsuario { get; set; }
        public virtual string Contraseña { get; set; }
        public virtual int Unidad { get; set; }
        public virtual string Rol { get; set; }
        public virtual string Estado { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}