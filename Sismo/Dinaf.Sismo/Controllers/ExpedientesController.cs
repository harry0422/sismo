
using Dinaf.Sismo.Application.Contracts.Personas;
using Dinaf.Sismo.Application.Personas.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers
{
    public class ExpedientesController : Controller
    {
        private readonly IPersonaService _personaService;

        public ExpedientesController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        // GET: Expedientes
        public ActionResult Index()
        {
            ListExpedientesDto expedientes = _personaService.GetExpedientesNiños();
            return View(expedientes);
        }

        // GET: Expedientes/Details/5
        public ActionResult Details(int id)
        {
            ExpedienteDto expediente = _personaService.GetExpediente(new PersonaExpedienteIdDto(id));
            return View(expediente);
        }

        // GET: Expedientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expedientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Expedientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Expedientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Expedientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Expedientes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
