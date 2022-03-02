using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ProteccionDeDerecho
{
    public class SolicitudesController : Controller
    {
        [Route("ProteccionDerechos/Solicitudes")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: SolicitudesController/Details/5
        public ActionResult SolicitudDetails(int id)
        {
            return View();
        }

        [Route("ProteccionDerecho/Solicitudes/Create")]
        public ActionResult CrearSolicitud()
        {
            return View();
        }

        // POST: SolicitudesController/Create
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

        // GET: SolicitudesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SolicitudesController/Edit/5
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

        // GET: SolicitudesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SolicitudesController/Delete/5
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
