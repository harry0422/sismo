using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
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
        private readonly ICondicionMedicaService _condicionMedicaService;

        public SolicitantesAdopcionController(ISolicitudAdopcionService solicitanteAdopcionService, ICondicionMedicaService condicionMedicaService)
        {
            _solicitanteAdopcionService = solicitanteAdopcionService;
            _condicionMedicaService = condicionMedicaService;
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
            SolicitudAdopcionDto solicitudAdopcion = _solicitanteAdopcionService.ObtenerSolicitudAdopcion(new NumeroSolicitudDto(numeroExpediente));
            IList<CondicionMedicaDto> condicionMedicas = _condicionMedicaService.GetCondicionesMedicas();

            return View(new SolicitudAdopcionViewModel(solicitudAdopcion, condicionMedicas));
        }

        [HttpPost]
        public ActionResult AgregarCaracteristicas(CaracteristicasAdopcionDto caracteristicasAdopcion)
        {
            try
            {
                _solicitanteAdopcionService.AgregarCaracteristicasAdopcion(caracteristicasAdopcion);
                return RedirectToAction(nameof(Details), new { numeroExpediente = caracteristicasAdopcion.NumeroExpediente });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Details), new { numeroExpediente = caracteristicasAdopcion.NumeroExpediente });
            }
        }
    }
}