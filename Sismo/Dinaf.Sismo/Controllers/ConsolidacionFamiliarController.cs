using Dinaf.Sismo.Application.Contracts.Personas;
using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Application.Seguimientos;
using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Application.Vulneraciones;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using Dinaf.Sismo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dinaf.Sismo.Controllers
{
    public class ConsolidacionFamiliarController : Controller
    {
        private readonly IPersonaService _personaService;
        private readonly IVulneracionService _vulneracionService;
        private readonly ISeguimientoService _seguimientoService;

        public ConsolidacionFamiliarController(IPersonaService personaService, IVulneracionService vulneracionService, ISeguimientoService seguimientoService)
        {
            _personaService = personaService;
            _vulneracionService = vulneracionService;
            _seguimientoService = seguimientoService;
        }

        // GET: ConsolidacionFamiliar/NnaEstadoAdoptabilidad
        public ActionResult NnaEstadoAdoptabilidad()
        {
            ListExpedientesDto expedientes = _personaService.GetNnaEstadoAdoptabilidad();
            return View(expedientes);
        }

        // GET: ConsolidacionFamiliar/DetalleNnaEstadoAdoptabilidad/5
        public ActionResult DetalleNnaEstadoAdoptabilidad(int id)
        {
            ExpedienteDto expediente = _personaService.GetExpediente(new PersonaExpedienteIdDto(id));
            ListVulneracionesDto vulneraciones = _vulneracionService.GetVulneraciones(new Application.Vulneraciones.DTOs.NumeroExpedienteDto(expediente.NumeroExpediente));
            ListSeguimientosDto medidasProteccion = _seguimientoService.GetMedidasProteccion(new Application.Seguimientos.DTOs.NumeroExpedienteDto(expediente.NumeroExpediente));
            ExpedienteNiñoViewModel viewModel = new ExpedienteNiñoViewModel(expediente, vulneraciones, medidasProteccion);

            return View(viewModel);
        }

        // GET: ConsolidacionFamiliar/Adultos
        public ActionResult SolicitantesAdopcion()
        {
            ListExpedientesDto expedientes = _personaService.GetSolicitantesAdopcion();
            return View(expedientes);
        }

        // GET: ConsolidacionFamiliar/DetalleSolicitantesAdopcion/5
        //public ActionResult DetalleSolicitantesAdopcion(int id)
        //{
        //    ExpedienteDto expediente = _personaService.GetExpediente(new PersonaExpedienteIdDto(id));
        //    ListVulneracionesDto vulneraciones = _vulneracionService.GetVulneraciones(new NumeroExpedienteDto(expediente.NumeroExpediente));
        //    ExpedienteNiñoViewModel viewModel = new ExpedienteNiñoViewModel(expediente, vulneraciones);

        //    return View(viewModel);
        //}

        // GET: ConsolidacionFamiliar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsolidacionFamiliar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            throw new NotImplementedException();
        }

        // GET: ConsolidacionFamiliar/Edit/5
        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        // POST: ConsolidacionFamiliar/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            throw new NotImplementedException();
        }

        // GET: ConsolidacionFamiliar/Delete/5
        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        // POST: ConsolidacionFamiliar/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
