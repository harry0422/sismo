using Dinaf.Sismo.Application.Buzon.DTOs;
using Dinaf.Sismo.Application.Buzon.Mappers;
using Dinaf.Sismo.Domain.Buzon.Entities;
using Dinaf.Sismo.Domain.Buzon.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.Buzon
{
    public class MensajeService : IMensajeService
    {
        private readonly IMensajeRepository _mensajeRepository;

        public IList<MensajeDto> ObtenerBandejaDeEntrada(UsuarioBuzonDto usuarioBuzon)
        {
            return _mensajeRepository.ObtenerPorUsuario(usuarioBuzon.Id).ToDto();
        }

        public MensajeDto ObtenerMensaje(MensajeIdDto mensajeId)
        {
            Mensaje mensaje = _mensajeRepository.Get(mensajeId.Valor);
            mensaje.MarcarComoLeido();
            _mensajeRepository.Update(mensaje);

            return mensaje.ToDto();
        }
    }
}
