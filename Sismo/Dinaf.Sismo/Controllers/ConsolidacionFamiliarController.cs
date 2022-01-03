using Dinaf.Sismo.Application.Anexos;
using Dinaf.Sismo.Application.Anexos.DTOs;
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
using System.Linq;

namespace Dinaf.Sismo.Controllers
{
    public class ConsolidacionFamiliarController : Controller
    {
        private readonly IPersonaService _personaService;
        private readonly IVulneracionService _vulneracionService;
        private readonly ISeguimientoService _seguimientoService;
        private readonly IAnexoService _anexoService;

        public ConsolidacionFamiliarController(
            IPersonaService personaService, 
            IVulneracionService vulneracionService, 
            ISeguimientoService seguimientoService, 
            IAnexoService anexoService)
        {
            _personaService = personaService;
            _vulneracionService = vulneracionService;
            _seguimientoService = seguimientoService;
            _anexoService = anexoService;
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
            NnaEstadoAdoptabilidadViewModel viewModel = new NnaEstadoAdoptabilidadViewModel(expediente, vulneraciones, medidasProteccion);

            return View(viewModel);
        }

        // GET: ConsolidacionFamiliar/SolicitantesAdopcion
        public ActionResult SolicitantesAdopcion()
        {
            ListExpedientesDto expedientes = _personaService.GetSolicitantesAdopcion();
            return View(expedientes);
        }

        // GET: ConsolidacionFamiliar/DetalleSolicitantesAdopcion/5
        public ActionResult DetalleSolicitantesAdopcion(int id)
        {
            ExpedienteDto expediente = _personaService.GetExpediente(new PersonaExpedienteIdDto(id));
            AnexoDto motivoAdopcion = _anexoService
                .GetAnexos(new Application.Anexos.DTOs.NumeroExpedienteDto(expediente.NumeroExpediente))
                .Detalles.Where(x => x.Asunto == "Adopción")
                .FirstOrDefault();

            SolicitanteAdopcionViewModel viewModel = new SolicitanteAdopcionViewModel(expediente, motivoAdopcion);

            return View(viewModel);
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