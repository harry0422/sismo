using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class CoincidenciasController : Controller
    {
        // GET: CoincidenciasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CoincidenciasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CoincidenciasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoincidenciasController/Create
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

        // GET: CoincidenciasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CoincidenciasController/Edit/5
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

        // GET: CoincidenciasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CoincidenciasController/Delete/5
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
