using Dinaf.Sismo.Application.Buzon.DTOs;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Buzon
{
    public interface IMensajeService
    {
        public IList<MensajeDto> ObtenerBandejaDeEntrada(UsuarioBuzonDto usuarioBuzon);
        public MensajeDto ObtenerMensaje(MensajeIdDto mensajeId);
    }
}