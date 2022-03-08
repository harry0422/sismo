using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ProteccionDerechos
{
    public class VulneracionesController : Controller
    {
        // GET: VulneracionesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VulneracionesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VulneracionesController/Create
        public ActionResult CreateVulneracion()
        {
            return View();
        }

        // POST: VulneracionesController/Create
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

        // GET: VulneracionesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VulneracionesController/Edit/5
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

        // GET: VulneracionesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VulneracionesController/Delete/5
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
