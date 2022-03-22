namespace Dinaf.Sismo.Application.Vulneraciones.DTOs
{
    public class TipoVulneracionIdDto
    {
        public TipoVulneracionIdDto(int valor)
        {
            Valor = valor;
        }

        public int Valor { get; set; }
    }
}