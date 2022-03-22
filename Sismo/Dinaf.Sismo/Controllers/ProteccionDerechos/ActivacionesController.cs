using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ProteccionDeDerecho
{
    public class ActivacionesController : Controller
    {
        [Route("ProteccionDerechos/Activaciones")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActivacionDetails(int id)
        {
            return View();
        }

        [Route("ProteccionDerecho/Activaciones/Create")]
        public ActionResult CrearActivacion()
        {
            return View();
        }

        // POST: ActivacionesController/Create
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

        // GET: ActivacionesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActivacionesController/Edit/5
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

        // GET: ActivacionesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActivacionesController/Delete/5
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
