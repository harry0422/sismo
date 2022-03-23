namespace Dinaf.Sismo.Application.Common
{
    public interface ICifradoService
    {
        public string CifrarContraseña(string password);
        public bool ValidarContraseña(string password, string correctHash);
    }
}