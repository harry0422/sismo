﻿using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.Seguimientos;
using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Application.Vulneraciones;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class ExpedientesNnaController : Controller
    {
        private readonly IExpedienteNnaService _expedienteNnaService;
        private readonly ICondicionMedicaService _condicionMedicaService;
        private readonly IVulneracionService _vulneracionService;
        private readonly ISeguimientoService _seguimientoService;

        public ExpedientesNnaController(
            IExpedienteNnaService expedienteNnaService, 
            ICondicionMedicaService condicionMedicaService, 
            IVulneracionService vulneracionService, 
            ISeguimientoService seguimientoService)
        {
            _expedienteNnaService = expedienteNnaService;
            _condicionMedicaService = condicionMedicaService;
            _vulneracionService = vulneracionService;
            _seguimientoService = seguimientoService;
        }

        [Route("ConsolidacionFamiliar/ExpedientesNna")]
        public ActionResult Index()
        {
            List<ExpedienteNnaDto> expedientesNna = _expedienteNnaService.GetNnaEstadoAdoptabilidad();
            return View(expedientesNna);
        }

        [Route("ConsolidacionFamiliar/ExpedientesNna/{numeroExpediente}")]
        public ActionResult Details(string numeroExpediente)
        {
            List<VulneracionDto> vulneraciones = _vulneracionService.GetVulneraciones(new Application.Vulneraciones.DTOs.NumeroExpedienteDto(numeroExpediente));
            List<SeguimientoDto> medidasProteccion = _seguimientoService.GetMedidasProteccion(new Application.Seguimientos.DTOs.NumeroExpedienteDto(numeroExpediente));
            ExpedienteNnaDto expedienteNna = _expedienteNnaService.GetNnaEstadoAdoptabilidad(new Application.ConsolidacionFamiliar.DTOs.NumeroExpedienteDto(numeroExpediente));
            List<CondicionMedicaDto> condicionesMedicas = _condicionMedicaService.GetCondicionesMedicas();

            return View(new ExpedienteNnaViewModel(expedienteNna, condicionesMedicas, vulneraciones, medidasProteccion));
        }
    }
}