using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class CaracteristicasAdopcionMap : ClassMap<CaracteristicasAdopcion>
    {
        public CaracteristicasAdopcionMap()
        {
            Table("caracteristicas_adopcion");
            Id(x => x.Id, "id");
            Map(x => x.NumeroExpediente, "numero_expediente");
            Map(x => x.Genero, "genero");
            Map(x => x.EdadMinima, "edad_minima");
            Map(x => x.EdadMaxima, "edad_maxima");
            Map(x => x.CondicionMedica, "condicion_medica");
            Map(x => x.CantidadHermanos, "cantidad_hermanos");
            Map(x => x.FechaCreacion, "fecha_creacion");
        }
    }
}