namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas
{
    public interface IFotografiaService
    {
        public void Guardar(string nombreArchivo, string rutaCarpeta, string fotoBase64);
    }
}