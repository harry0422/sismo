namespace Dinaf.Sismo.Application.Common
{
    public interface IArchivosService
    {
        public void Guardar(string nombreArchivo, string rutaCarpeta, string base64);
    }
}