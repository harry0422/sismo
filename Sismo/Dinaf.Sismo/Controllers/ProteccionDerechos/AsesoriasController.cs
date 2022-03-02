using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ProteccionDeDerecho
{
    public class AsesoriasController : Controller
    {
        [Route("ProteccionDerechos/Asesorias")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: AsesoriasController/Details/5
        public ActionResult AsesoriaDetails(int id)
        {
            return View();
        }

        [Route("ProteccionDerecho/Asesorias/Create")]
        public ActionResult CrearAsesoria()
        {
            return View();
        }

        // POST: AsesoriasController/Create
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

        // GET: AsesoriasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AsesoriasController/Edit/5
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

        // GET: AsesoriasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AsesoriasController/Delete/5
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
