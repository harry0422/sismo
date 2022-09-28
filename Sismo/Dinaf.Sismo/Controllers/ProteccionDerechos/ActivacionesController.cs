using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ProteccionDeDerecho
{
    public class ActivacionesController : Controller
    {
        [Route("ProteccionDerechos/Activaciones")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActivacionDetails(int id)
        {
            return View();
        }

        [Route("ProteccionDerecho/Activaciones/Create")]
        public ActionResult CrearActivacion()
        {
            return View();
        }
    }
}