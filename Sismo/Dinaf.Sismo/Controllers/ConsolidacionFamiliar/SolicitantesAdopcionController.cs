using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class SolicitantesAdopcionController : Controller
    {
        private readonly ISolicitudAdopcionService _solicitanteAdopcionService;

        public SolicitantesAdopcionController(ISolicitudAdopcionService solicitanteAdopcionService)
        {
            _solicitanteAdopcionService = solicitanteAdopcionService;
        }

        [Route("ConsolidacionFamiliar/SolicitantesAdopcion")]
        public ActionResult Index()
        {
            IList<SolicitudAdopcionDto> solicitudesAdopcion = _solicitanteAdopcionService.ObtenerSolicitudesAdopcion();
            return View(solicitudesAdopcion);
        }

        [Route("ConsolidacionFamiliar/SolicitantesAdopcion/{numeroExpediente}")]
        public ActionResult Details(string numeroExpediente)
        {
            SolicitudAdopcionDto solicitudAdopcion = _solicitanteAdopcionService
                .ObtenerSolicitudAdopcion(new NumeroSolicitudDto(numeroExpediente));

            return View(new SolicitudAdopcionViewModel(solicitudAdopcion));
        }

        [HttpPost]
        public ActionResult AgregarCaracteristicas(CaracteristicasAdopcionDto caracteristicasAdopcion)
        {
            try
            {
                _solicitanteAdopcionService.AgregarCaracteristicasAdopcion(caracteristicasAdopcion);
                return RedirectToAction("Index", "Coincidencias", new { numeroExpediente = caracteristicasAdopcion.NumeroExpediente });
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Coincidencias", new { numeroExpediente = caracteristicasAdopcion.NumeroExpediente });
            }
        }
    }
}