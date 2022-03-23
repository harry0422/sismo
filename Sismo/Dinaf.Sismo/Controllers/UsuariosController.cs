using Dinaf.Sismo.Application.Usuarios;
using Dinaf.Sismo.Application.Usuarios.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dinaf.Sismo.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: UsuariosController1
        public ActionResult Index()
        {
            IList<UsuarioDto> usuarios = _usuarioService.ObtenerTodos();
            return View(usuarios);
        }

        // POST: UsuariosController1/Create
        [HttpPost]
        public ActionResult Create(CredencialesDto credenciales)
        {
            try
            {
                _usuarioService.CrearCredenciales(credenciales);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosController1/Edit/5
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

        // GET: UsuariosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosController1/Delete/5
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
