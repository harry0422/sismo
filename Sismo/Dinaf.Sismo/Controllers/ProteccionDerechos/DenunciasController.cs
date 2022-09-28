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
    }
}