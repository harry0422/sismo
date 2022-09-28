using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class EmparejamientosController : Controller
    {
        private readonly IEmparejamientoService _emparejamientoService;

        public EmparejamientosController(IEmparejamientoService emparejamientoService)
        {
            _emparejamientoService = emparejamientoService;
        }

        [Route("ConsolidacionFamiliar/Emparejamientos")]
        public ActionResult Index()
        {
            IList<EmparejamientoDto> emparejamientos = _emparejamientoService.ObtenerEmparejamientos();
            return View(emparejamientos);
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/{expedienteNna}")]
        public ActionResult Details(string expedienteNna)
        {
            EmparejamientoDto emparejamiento = _emparejamientoService.ObtenerDetalleEmparejamiento(new NumeroExpedienteNnaDto(expedienteNna));
            return View(emparejamiento);
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/Create")]
        public ActionResult Create(string expedienteNna, string solicitudAdopcion)
        {
            ViewBag.expedienteNna = expedienteNna;
            ViewBag.solicitudAdopcion = solicitudAdopcion;
            return View();
        }

        [HttpPost]
        [Route("ConsolidacionFamiliar/Emparejamientos/Create")]
        public ActionResult Create(NuevoEmparejamientoDto nuevoEmparejamiento)
        {
            try
            {
                _emparejamientoService.CrearPreEmparejamiento(nuevoEmparejamiento);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/NextStep")]
        public ActionResult NextStep(string Id, string expedienteNna)
        {
            ViewBag.Id = Id;
            ViewBag.ExpedienteNna = expedienteNna;

            return View();
        }

        [HttpPost]
        [Route("ConsolidacionFamiliar/Emparejamientos/NextStep")]
        public ActionResult NextStep(InformacionSeguimientoDto dto, IFormFile adjunto)
        {
            _emparejamientoService.CrearAvanzarEtapa(dto);
            return RedirectToAction(nameof(Details), new { expedienteNna = dto.ExpedienteNna });
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/Seguimientos")]
        public ActionResult Seguimientos()
        {
            IList<SeguimientoDto> seguimientos = _emparejamientoService.ObtenerSeguimientos();
            return View(seguimientos);
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/{emparejamientoId}/Seguimientos")]
        public ActionResult SeguimientosPorEmparejamiento(string emparejamientoId)
        {
            IList<SeguimientoDto> seguimientos = _emparejamientoService.ObtenerSeguimientos(new EmparejamientoIdDto(emparejamientoId));
            return View(seguimientos);
        }
    }
}