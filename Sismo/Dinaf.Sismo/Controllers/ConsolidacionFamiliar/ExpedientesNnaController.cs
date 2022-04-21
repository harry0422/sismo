using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.CondicionesMedicas.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.MedidasProteccion;
using Dinaf.Sismo.Application.ProteccionDerechos.MedidasProteccion.DTOs;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Application.Vulneraciones;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
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
        private readonly IMedidaProteccionService _seguimientoService;
        private readonly IPersonaService _personaService;

        public ExpedientesNnaController(IExpedienteNnaService expedienteNnaService, ICondicionMedicaService condicionMedicaService, IVulneracionService vulneracionService, IMedidaProteccionService seguimientoService, IPersonaService personaService)
        {
            _expedienteNnaService = expedienteNnaService;
            _condicionMedicaService = condicionMedicaService;
            _vulneracionService = vulneracionService;
            _seguimientoService = seguimientoService;
            _personaService = personaService;
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
            IList<VulneracionDto> vulneraciones = _vulneracionService.GetVulneraciones(new Application.Vulneraciones.DTOs.NumeroExpedienteDto(numeroExpediente));
            IList<MedidaProteccionDto> medidasProteccion = _seguimientoService.GetMedidasProteccion(new Application.ProteccionDerechos.MedidasProteccion.DTOs.NumeroExpedienteDto(numeroExpediente));
            ExpedienteNnaDto expedienteNna = _expedienteNnaService.GetNnaEstadoAdoptabilidad(new NumeroExpedienteNnaDto(numeroExpediente));
            IList<CondicionMedicaDto> condicionesMedicas = _condicionMedicaService.GetCondicionesMedicas();
            IList<PersonaDto> familiares = _personaService.ObtenerFamiliaresPorExpediente(new Application.ProteccionDerechos.Personas.DTOs.NumeroExpedienteDto(numeroExpediente));

            return View(new ExpedienteNnaViewModel(expedienteNna, condicionesMedicas, vulneraciones, medidasProteccion, familiares));
        }
    }
}