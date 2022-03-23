using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes;
using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers.ProteccionDerechos
{
    public class ProteccionDerechosController : Controller
    {
        private readonly IExpedienteService _expedienteService;
        private readonly IPersonaService _personaService;

        public ProteccionDerechosController(IExpedienteService expedienteService, IPersonaService personaService)
        {
            _expedienteService = expedienteService;
            _personaService = personaService;
        }

        [Route("ProteccionDerechos/tipoInstrumento/{tipoInstrumento}")]
        public ActionResult Index(string tipoInstrumento)
        {
            IList<ExpedienteDto> expedientes = _expedienteService.GetExpedientePorTipo(new TipoExpedienteDto(tipoInstrumento));
            ViewBag.TipoInstrumento = tipoInstrumento;

            return View(expedientes);
        }

        [Route("ProteccionDerechos/{numeroExpediente}")]
        public ActionResult Details(string numeroExpediente)
        {
            ExpedienteDto expediente = _expedienteService.GetExpediente(new Application.ProteccionDerechos.Expedientes.DTOs.NumeroExpedienteDto(numeroExpediente));
            IList<PersonaDto> personas = _personaService.GetPersonasByExpediente(new Application.ProteccionDerechos.Personas.DTOs.NumeroExpedienteDto(numeroExpediente));

            return View(new ExpedienteViewModel(expediente, personas));
        }
    }
}