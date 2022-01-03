namespace Dinaf.Sismo.Application.Personas.DTOs
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