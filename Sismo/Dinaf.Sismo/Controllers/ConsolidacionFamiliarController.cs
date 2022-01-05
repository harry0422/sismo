using Dinaf.Sismo.Application.ConsolidacionFamiliar;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers
{
    public class ConsolidacionFamiliarController : Controller
    {

        private readonly IConsolidacionFamiliarService _consolidacionFamiliarService;

        public ConsolidacionFamiliarController(IConsolidacionFamiliarService consolidacionFamiliarService)
        {
            _consolidacionFamiliarService = consolidacionFamiliarService;
        }


        // GET: ConsolidacionFamiliar/NnaEstadoAdoptabilidad
        public ActionResult NnaEstadoAdoptabilidad()
        {
            List<ExpedienteNnaDto> expedientesNna = _consolidacionFamiliarService.GetNnaEstadoAdoptabilidad();
            return View(expedientesNna);
        }

        // GET: ConsolidacionFamiliar/DetalleNnaEstadoAdoptabilidad/5
        public ActionResult DetalleNnaEstadoAdoptabilidad(string id)
        {
            //ExpedienteDto expediente = _personaService.GetExpediente(new PersonaExpedienteIdDto(id));
            //ListVulneracionesDto vulneraciones = _vulneracionService.GetVulneraciones(new Application.Vulneraciones.DTOs.NumeroExpedienteDto(expediente.NumeroExpediente));
            //ListSeguimientosDto medidasProteccion = _seguimientoService.GetMedidasProteccion(new Application.Seguimientos.DTOs.NumeroExpedienteDto(expediente.NumeroExpediente));
            //NnaEstadoAdoptabilidadViewModel viewModel = new NnaEstadoAdoptabilidadViewModel(expediente, vulneraciones, medidasProteccion);

            ExpedienteNnaDto expedienteNna = _consolidacionFamiliarService.GetNnaEstadoAdoptabilidad(new NumeroExpedienteDto(id));
            return View(expedienteNna);
        }

        // GET: ConsolidacionFamiliar/SolicitantesAdopcion
        public ActionResult SolicitantesAdopcion()
        {
            IList<SolicitudAdopcionDto> solicitudesAdopcion = _consolidacionFamiliarService.GetSolicitudesAdopcion();
            return View(solicitudesAdopcion);
        }

        // GET: ConsolidacionFamiliar/DetalleSolicitantesAdopcion/5
        public ActionResult DetalleSolicitantesAdopcion(string numeroExpediente)
        {
            SolicitudAdopcionDto solicitudAdopcion = _consolidacionFamiliarService.GetSolicitudAdopcion(new NumeroExpedienteDto(numeroExpediente));
            return View(solicitudAdopcion);
        }

        // GET: ConsolidacionFamiliar/CrearEmparejamiento
        public ActionResult CrearEmparejamiento()
        {
            return View();
        }

        // GET: ConsolidacionFamiliar/Emparejamiento
        public ActionResult Emparejamiento()
        {
            return View();
        }

        // GET: ConsolidacionFamiliar/DetalleEmparejamiento
        public ActionResult DetalleEmparejamiento()
        {
            return View();
        }

        // GET: ConsolidacionFamiliar/CrearMatch
        public ActionResult CrearMatch()
        {
            return View();
        }

        // GET: ConsolidacionFamiliar/Seguimiento
        public ActionResult Seguimiento()
        {
            return View();
        }

        // GET: ConsolidacionFamiliar/DetalleSeguimiento
        public ActionResult DetalleSeguimiento()
        {
            return View();
        }

        // GET: ConsolidacionFamiliar/CrearEvento
        public ActionResult CrearEvento()
        {
            return View();
        }

        // GET: ConsolidacionFamiliar/DetalleEvento
        public ActionResult DetalleEvento()
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