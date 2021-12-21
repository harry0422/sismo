using Dinaf.Sismo.Application.Anexos.DTOs;

namespace Dinaf.Sismo.Application.Anexos
{
    public interface IAnexoService
    {
        ListAnexosDto GetAnexos(NumeroExpedienteDto numeroExpediente);
    }
}