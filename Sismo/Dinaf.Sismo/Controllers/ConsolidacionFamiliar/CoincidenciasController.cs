using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class CoincidenciasController : Controller
    {
        private readonly IEmparejamientoService _emparejamientoService;

        public CoincidenciasController(IEmparejamientoService emparejamientoService)
        {
            _emparejamientoService = emparejamientoService;
        }

        [Route("ConsolidacionFamiliar/Coincidencias/{numeroExpediente}")]
        public ActionResult Index(string numeroExpediente)
        {
            var emparejamientos = _emparejamientoService.ObtenerNnaParaPreEmparejamiento(new NumeroSolicitudDto(numeroExpediente));
            ViewBag.NumeroExpediente = numeroExpediente;

            return View(emparejamientos);
        }
    }
}