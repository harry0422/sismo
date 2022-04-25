using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class CamaraController : Controller
    {
        // GET: CamaraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CamaraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CamaraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CamaraController/Create
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

        // GET: CamaraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CamaraController/Edit/5
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

        // GET: CamaraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CamaraController/Delete/5
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
