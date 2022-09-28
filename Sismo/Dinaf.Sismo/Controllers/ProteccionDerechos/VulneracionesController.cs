using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers.ProteccionDerechos
{
    public class VulneracionesController : Controller
    {
        // GET: VulneracionesController/Create
        public ActionResult CreateVulneracion()
        {
            return View();
        }
    }
}