namespace Dinaf.Sismo.Application.Expedientes.DTOs
{
    public class ExpedienteIdDto
    {
        public ExpedienteIdDto(int valor)
        {
            Valor = valor;
        }

        public int Valor { get; set; }
    }
}