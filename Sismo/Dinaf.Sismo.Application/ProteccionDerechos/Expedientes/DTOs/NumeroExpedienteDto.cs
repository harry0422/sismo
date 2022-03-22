namespace Dinaf.Sismo.Application.ProteccionDerechos.Expedientes.DTOs
{
    public class NumeroExpedienteDto
    {
        public NumeroExpedienteDto(string valor)
        {
            Valor = valor;
        }

        public string Valor { get; set; }
    }
}