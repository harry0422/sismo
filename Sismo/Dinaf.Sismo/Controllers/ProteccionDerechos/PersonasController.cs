using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dinaf.Sismo.Controllers.ProteccionDerechos
{
    public class PersonasController : Controller
    {
        private readonly IPersonaService _personaService;

        public PersonasController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpPost]
        [Route("Personas")]
        public ActionResult Create(NuevaPersonaDto nuevaPersona)
        {
            try
            {
                _personaService.AgregarPersona(nuevaPersona);
                return RedirectToAction("Details", "ProteccionDerechos", new { NumeroExpediente = nuevaPersona.NumeroExpediente });
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}