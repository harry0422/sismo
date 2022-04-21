using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes;
using Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Application.Usuarios;
using Dinaf.Sismo.Application.Usuarios.DTOs;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers.ProteccionDerechos
{
    public class ProteccionDerechosController : Controller
    {
        private readonly IExpedienteService _expedienteService;
        private readonly IPersonaService _personaService;
        private readonly IUnidadService _unidadService;

        public ProteccionDerechosController(
            IExpedienteService expedienteService, 
            IPersonaService personaService, 
            IUnidadService unidadService)
        {
            _expedienteService = expedienteService;
            _personaService = personaService;
            _unidadService = unidadService;
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
            IList<PersonaDto> personas = _personaService.ObtenerPersonasPorExpediente(new Application.ProteccionDerechos.Personas.DTOs.NumeroExpedienteDto(numeroExpediente));
            IList<UnidadDto> unidades = _unidadService.ObtenerUnidades();

            return View(new ExpedienteViewModel(expediente, personas, unidades));
        }

        [Route("/ProteccionDerechos/Create/{tipoInstrumento}")]
        public ActionResult Create(string tipoInstrumento)
        {
            switch (tipoInstrumento)
            {
                case "Denuncia":
                    return RedirectToAction("CrearDenuncia", "Denuncias");
                case "Asesoría":
                    return RedirectToAction("CrearAsesoria", "Asesorias");
                case "Solicitud":
                    return RedirectToAction("CrearSolicitud", "Solicitudes");
                case "Activación":
                    return RedirectToAction("CrearActivacion", "Activaciones");
                default:
                    return RedirectToAction("Index", "ProteccionDerechos", new { tipoInstrumento = tipoInstrumento });
            }
           
        }
    }
}