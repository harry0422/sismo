namespace Dinaf.Sismo.Application.ProteccionDerechos.MedidasProteccion.DTOs
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