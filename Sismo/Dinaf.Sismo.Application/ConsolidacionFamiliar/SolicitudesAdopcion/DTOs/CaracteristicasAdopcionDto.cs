namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs
{
    public class CaracteristicasAdopcionDto
    {
        public CaracteristicasAdopcionDto()
        {
            NumeroExpediente = "";
            Genero = "NA";
            EdadMinima = 0;
            EdadMaxima = 0;
            CondicionMedica = 0;
            CantidadHermanos = 0;
        }

        //TODO: Revisar si es necesario
        public string NumeroExpediente { get; set; }
        public string Genero { get; set; }
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; }
        public int CondicionMedica { get; set; }
        public int CantidadHermanos { get; set; }
    }
}