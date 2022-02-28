using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Dinaf.Sismo.Controllers.ConsolidacionFamiliar
{
    public class EmparejamientosController : Controller
    {
        private readonly IEmparejamientoService _emparejamientoService;

        public EmparejamientosController(IEmparejamientoService emparejamientoService)
        {
            _emparejamientoService = emparejamientoService;
        }

        [Route("ConsolidacionFamiliar/Emparejamientos")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/{expedienteNna}")]
        public ActionResult Details(string expedienteNna)
        {
            return View();
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/Create")]
        public ActionResult Create(string expedienteNna, string solicitudAdopcion)
        {
            return View();
        }

        [HttpPost]
        [Route("ConsolidacionFamiliar/Emparejamientos/Create")]
        public ActionResult Create(NuevoEmparejamientoDto nuevoEmparejamiento)
        {
            try
            {
                _emparejamientoService.CrearPreEmparejamiento(nuevoEmparejamiento);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Route("ConsolidacionFamiliar/Emparejamientos/NextStep")]
        public ActionResult NextStep(string expedienteNna, string solicitudAdopcion)
        {
            return View();
        }
    }
}