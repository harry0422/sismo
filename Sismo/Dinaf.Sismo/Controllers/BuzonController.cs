using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.Buzon
{
    public class BuzonController : Controller
    {
        // GET: BuzonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BuzonController/Details/5
        public ActionResult BuzonDetails(int id)
        {
            return View();
        }

        // GET: BuzonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuzonController/Create
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

        // GET: BuzonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuzonController/Edit/5
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

        // GET: BuzonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuzonController/Delete/5
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
