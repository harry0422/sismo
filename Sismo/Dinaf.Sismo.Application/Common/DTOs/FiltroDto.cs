namespace Dinaf.Sismo.Application.Contracts.Common.DTOs
{
    public class FiltroDto
    {
        public FiltroDto(int numeroPagina, int elementosPorPagina)
        {
            NumeroPagina = numeroPagina;
            ElementosPorPagina = elementosPorPagina;
        }

        public int NumeroPagina { get; set; }
        public int ElementosPorPagina { get; set; }
    }
}
