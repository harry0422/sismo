using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using Dinaf.Sismo.Application.MedidasProteccion;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.Application.Vulneraciones;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class ExpedientesNnaController : Controller
    {
        private readonly IExpedienteNnaService _expedienteNnaService;
        private readonly IVulneracionService _vulneracionService;
        private readonly IMedidaProteccionService _seguimientoService;
        private readonly IPersonaService _personaService;
        private readonly IEmparejamientoService _emparejamientoService;

        public ExpedientesNnaController(
            IExpedienteNnaService expedienteNnaService, 
            IVulneracionService vulneracionService, 
            IMedidaProteccionService seguimientoService, 
            IPersonaService personaService, 
            IEmparejamientoService emparejamientoService)
        {
            _expedienteNnaService = expedienteNnaService;
            _vulneracionService = vulneracionService;
            _seguimientoService = seguimientoService;
            _personaService = personaService;
            _emparejamientoService = emparejamientoService;
        }

        [Route("ConsolidacionFamiliar/ExpedientesNna")]
        public ActionResult Index()
        {
            IList<ExpedienteNnaDto> expedientesNna = _expedienteNnaService.GetNnaEstadoAdoptabilidad();
            return View(expedientesNna);
        }

        [Route("ConsolidacionFamiliar/ExpedientesNna/{numeroExpediente}")]
        public ActionResult Details(string numeroExpediente)
        {
            var vulneraciones = _vulneracionService.GetVulneraciones(new Application.Vulneraciones.DTOs.NumeroExpedienteDto(numeroExpediente));
            var medidasProteccion = _seguimientoService.GetMedidasProteccion(new Application.ProteccionDerechos.MedidasProteccion.DTOs.NumeroExpedienteDto(numeroExpediente));
            var expedienteNna = _expedienteNnaService.GetNnaEstadoAdoptabilidad(new NumeroExpedienteNnaDto(numeroExpediente));
            var familiares = _personaService.ObtenerFamiliaresPorExpediente(new Application.ProteccionDerechos.Personas.DTOs.NumeroExpedienteDto(numeroExpediente));
            var emparejamientos = _emparejamientoService.ObtenerSolicitantesParaPreEmparejamiento(new NumeroExpedienteNnaDto(numeroExpediente));

            return View(new ExpedienteNnaViewModel(expedienteNna, vulneraciones, medidasProteccion, familiares, emparejamientos));
        }

        [HttpPost]
        [Route("ConsolidacionFamiliar/ExpedientesNna/{numeroExpediente}/Caracteristicas")]
        public ActionResult AgregarCaracteristicas(string numeroExpediente, CaracteristicasDto caracteristicas)
        {
            _expedienteNnaService.AddCaracteristicas(caracteristicas);
            return RedirectToAction("Details", new { numeroExpediente = numeroExpediente });
        }
    }
}