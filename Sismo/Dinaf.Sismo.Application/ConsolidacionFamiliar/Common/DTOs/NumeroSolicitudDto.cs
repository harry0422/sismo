namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs
{
    public class NumeroSolicitudDto
    {
        public NumeroSolicitudDto(string valor)
        {
            Valor = valor;
        }

        public string Valor { get; set; }
    }
}