using Dinaf.Sismo.Application.Common;
using System;
using System.IO;

namespace Dinaf.Sismo.Adapters.Common
{
    public class ArchivosService : IArchivosService
    {
        public void Guardar(string nombreArchivo, string rutaCarpeta, string base64)
        {
            if (!Directory.Exists(rutaCarpeta))
                Directory.CreateDirectory(rutaCarpeta);

            var bytesFoto = Convert.FromBase64String(base64);

            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            File.WriteAllBytes(rutaCompleta, bytesFoto);
        }
    }
}