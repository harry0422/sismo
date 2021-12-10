using Dinaf.Sismo.Application.Expedientes;
using Dinaf.Sismo.Application.Expedientes.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers
{
    public class ExpedientesController : Controller
    {
        private readonly IExpedienteService _expedienteService;

        public ExpedientesController(IExpedienteService expedienteService)
        {
            _expedienteService = expedienteService;
        }

        // GET: Expedientes
        public ActionResult Index()
        {
            ListExpedientesDto expedientes = _expedienteService.GetExpedientes();
            return View(expedientes);
        }

        // GET: Expedientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
