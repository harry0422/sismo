namespace Dinaf.Sismo.Application.Anexos.DTOs
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