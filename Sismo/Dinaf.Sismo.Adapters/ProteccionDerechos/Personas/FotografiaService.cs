using Dinaf.Sismo.Application.ProteccionDerechos.Personas;
using System;
using System.IO;

namespace Dinaf.Sismo.Adapters.ProteccionDerechos.Personas
{
    public class FotografiaService : IFotografiaService
    {
        public void Guardar(string nombreArchivo, string rutaCarpeta, string fotoBase64)
        {
            if (!Directory.Exists(rutaCarpeta))
                Directory.CreateDirectory(rutaCarpeta);

            var bytesFoto = Convert.FromBase64String(fotoBase64);

            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            File.WriteAllBytes(rutaCompleta, bytesFoto);
        }
    }
}