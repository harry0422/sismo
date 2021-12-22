using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers
{
    public class Emparejamiento : Controller
    {
        // GET: Emparejamiento
        public ActionResult Index()
        {
            return View();
        }

        // GET: Emparejamiento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emparejamiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emparejamiento/Create
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

        // GET: Emparejamiento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emparejamiento/Edit/5
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

        // GET: Emparejamiento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emparejamiento/Delete/5
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
