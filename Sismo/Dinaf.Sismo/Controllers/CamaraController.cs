using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs;
using Dinaf.Sismo.Requests;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Dinaf.Sismo.Controllers
{
    public class CamaraController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IPersonaService _personaService;

        public CamaraController(IWebHostEnvironment env, IPersonaService personaService)
        {
            _env = env;
            _personaService = personaService;
        }

        public ActionResult Index(int personaId)
        {
            return View(personaId);
        }

        [HttpPost]
        public ActionResult Create(FotoPerfilRequest fotoPerfilRequest)
        {
            try
            {

                string fotoBase64 = fotoPerfilRequest.FotoBase64.Split(";")[1].Replace("base64,", string.Empty);
                string rutaCarpeta = _env.ContentRootPath + "/wwwroot/ProfilePics";
                string formato = fotoPerfilRequest.FotoBase64.Split(";")[0].Replace("data:image/", string.Empty);

                FotoPerfilDto fotoPerfil1 = new FotoPerfilDto(
                    fotoPerfilRequest.PersonaId,
                    rutaCarpeta,
                    fotoBase64,
                    formato);

                _personaService.AgregarFotoDePerfil(fotoPerfil1);

                return Ok();
            }
            catch
            {
                //TODO: Return error
                return View();
            }
        }

    }
}