using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dinaf.Sismo.Controllers
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
    }
}