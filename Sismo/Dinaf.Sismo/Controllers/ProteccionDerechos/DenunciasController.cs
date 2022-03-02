using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ProteccionDeDerecho
{
    public class DenunciasController : Controller
    {
        
        [Route("ProteccionDerechos/Denuncias")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: DenunciasController/Details/5
        public ActionResult DenunciaDetails(int id)
        {
            return View();
        }

        [Route("ProteccionDerecho/Denuncias/Create")]
        public ActionResult CrearDenuncia()
        {
            return View();
        }

        [Route("ProteccionDerecho/Denuncias/CreatePerson")]
        public ActionResult CrearPersona()
        {
            return View();
        }

        // POST: DenunciasController/Create
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

        // GET: DenunciasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DenunciasController/Edit/5
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

        // GET: DenunciasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DenunciasController/Delete/5
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
