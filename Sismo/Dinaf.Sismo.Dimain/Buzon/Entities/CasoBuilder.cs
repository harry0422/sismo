using Dinaf.Sismo.Domain.Buzon.Repositories;
using Dinaf.Sismo.Domain.Buzon.Services;
using System;

namespace Dinaf.Sismo.Domain.Buzon.Entities
{
    public class CasoBuilder
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ITipoGestionRepository _tipoGestionRepository;

        public CasoBuilder(IUsuarioService usuarioService, ITipoGestionRepository tipoGestionRepository)
        {
            _usuarioService = usuarioService;
            _tipoGestionRepository = tipoGestionRepository;
        }

        private Usuario _usuarioApertura;
        private Usuario _usuarioAsignado;
        private TipoGestion _tipoGestion;
        private string _numeroInstrumento;

        public CasoBuilder ConUsuarioApertura(int usuarioId)
        {
            _usuarioApertura = _usuarioService.ObtenerUsuario(usuarioId);
            return this;
        }

        public CasoBuilder ConUsuarioAsignado(int usuarioId)
        {
            _usuarioAsignado = _usuarioService.ObtenerUsuario(usuarioId);
            return this;
        }

        public CasoBuilder ConTipoGestion(int TipoGestionId)
        {
            _tipoGestion = _tipoGestionRepository.Get(TipoGestionId);
            return this;
        }

        public CasoBuilder ConNumeroInstrumento(string numeroInstrumento)
        {
            _numeroInstrumento = numeroInstrumento;
            return this;
        }

        //TODO: Validar objeto antes de retornarlo
        public Caso ObtenerInstancia()
        {
            return new Caso(_usuarioApertura, _tipoGestion, _numeroInstrumento, _usuarioAsignado);
        }
    }
}