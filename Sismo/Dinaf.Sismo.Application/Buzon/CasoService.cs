using Dinaf.Sismo.Application.Buzon.DTOs;
using Dinaf.Sismo.Domain.Buzon.Entities;
using Dinaf.Sismo.Domain.Buzon.Repositories;
using Dinaf.Sismo.Domain.Buzon.Services;

namespace Dinaf.Sismo.Application.Buzon
{
    public class CasoService : ICasoService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ITipoGestionRepository _tipoGestionRepository;
        private readonly ICasoRepository _casoRepository;

        public CasoService(IUsuarioService usuarioService, ITipoGestionRepository tipoGestionRepository)
        {
            _usuarioService = usuarioService;
            _tipoGestionRepository = tipoGestionRepository;
        }

        public void CrearNuevoTicket(NuevoTicketDto nuevoTicket)
        {
            Caso caso = new CasoBuilder(_usuarioService, _tipoGestionRepository)
                .ConNumeroInstrumento(nuevoTicket.NumeroInstrumento)
                .ConUsuarioApertura(nuevoTicket.UsuarioApertura)
                .ConUsuarioAsignado(nuevoTicket.UsuarioAsignado)
                .ConTipoGestion(nuevoTicket.TipoGestion)
                .ObtenerInstancia();

            caso.AgregarMensaje(nuevoTicket.Asunto, nuevoTicket.Contenido);

            _casoRepository.Insert(caso);
        }

        public void CerrarCaso(CasoIdDto casoId)
        {
            Caso caso = _casoRepository.Get(casoId.Valor);
            caso.CerrarCaso();
            _casoRepository.Update(caso);
        }
    }
}