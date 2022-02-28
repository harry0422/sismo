namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs
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