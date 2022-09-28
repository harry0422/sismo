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

        public ActionResult AsesoriaDetails(int id)
        {
            return View();
        }

        [Route("ProteccionDerecho/Asesorias/Create")]
        public ActionResult CrearAsesoria()
        {
            return View();
        }
    }
}