using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class EmparejamientosController : Controller
    {
        private readonly IEmparejamientoService _emparejamientoService;
        private readonly IExpedienteNnaService _expedienteNnaService;
        private readonly IWebHostEnvironment _env;

        public EmparejamientosController(IEmparejamientoService emparejamientoService, IExpedienteNnaService expedienteNnaService, IWebHostEnvironment env)
        {
            _emparejamientoService = emparejamientoService;
            _expedienteNnaService = expedienteNnaService;
            _env = env;
        }

        [Route("ConsolidacionFamiliar/Emparejamientos")]
        public ActionResult Index()
        {
            IList<NnaEmparejamientoDto> emparejamientos = _emparejamientoService.ObtenerEmparejamientos();
            return View(emparejamientos);
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/{expedienteNna}")]
        public ActionResult Details(string expedienteNna)
        {
            NnaEmparejamientoDto emparejamiento = _emparejamientoService.ObtenerDetalleEmparejamiento(new NumeroExpedienteNnaDto(expedienteNna));
            ExpedienteNnaDto nna = _expedienteNnaService.GetNnaEstadoAdoptabilidad(new NumeroExpedienteNnaDto(expedienteNna));
            return View(new EmparejamientoViewModel(emparejamiento, nna));
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

        //TODO: Improve root path management
        [HttpPost]
        [Route("ConsolidacionFamiliar/Emparejamientos/NextStep")]
        public ActionResult NextStep(InformacionSeguimientoDto dto, IFormFile adjunto)
        {
            try
            {
                dto.NombreArchivo = adjunto.FileName;
                dto.Base64 = GetBase64(adjunto);
                dto.RutaCarpeta = _env.ContentRootPath + "/wwwroot/Uploads";

                _emparejamientoService.CrearAvanzarEtapa(dto);

                return RedirectToAction(nameof(Details), new { expedienteNna = dto.ExpedienteNna });
            }
            catch (Exception e)
            {
                return View();
            }
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

        private string GetBase64(IFormFile formFile)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                formFile.CopyTo(stream);
                var fileBytes = stream.ToArray();
                return Convert.ToBase64String(fileBytes);
            }
        }
    }
}