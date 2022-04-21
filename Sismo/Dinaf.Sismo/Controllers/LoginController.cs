using Dinaf.Sismo.Application.Usuarios;
using Dinaf.Sismo.Application.Usuarios.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [Route("auth")]
        public ActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost]
        [Route("auth")]
        public ActionResult Create(CredencialesDto credenciales)
        {
            try
            {
                UsuarioDto usuario = _usuarioService.ObtenerPor(credenciales);
                HttpContext.Session.SetString("Nombre", usuario.Nombre);
                HttpContext.Session.SetInt32("Perfil", usuario.Perfil);
                HttpContext.Session.SetInt32("Unidad", usuario.Unidad);
                HttpContext.Session.SetInt32("UsuarioId", usuario.Id);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}