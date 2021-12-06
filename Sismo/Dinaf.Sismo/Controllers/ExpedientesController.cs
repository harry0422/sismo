using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Controllers
{
    public class ExpedientesController : Controller
    {
        // GET: Expedientes
        public ActionResult Index()
        {
            return View();
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
