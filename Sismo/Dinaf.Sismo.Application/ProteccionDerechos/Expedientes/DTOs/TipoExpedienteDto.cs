namespace Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs
{
    public class TipoExpedienteDto
    {
        public TipoExpedienteDto(string valor)
        {
            Valor = valor;
        }

        public string Valor { get; set; }
    }
}