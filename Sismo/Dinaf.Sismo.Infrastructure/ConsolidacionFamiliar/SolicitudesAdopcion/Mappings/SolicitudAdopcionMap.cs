using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class SolicitudAdopcionMap : ClassMap<SolicitudAdopcion>
    {
        public SolicitudAdopcionMap()
        {
            Table("expediente");
            Id(x => x.Id, "numero_expediente");
            Map(x => x.FechaCreacion, "fechacreacion");
            Map(x => x.TipoInstrumento, "tiposinstrumentos");
            Map(x => x.Estado, "estado");
            Map(x => x.Procedencia, "procedencia");
            HasMany(x => x.HistoricoDeBusquedas)
                .KeyColumn("numero_expediente")
                .Not.LazyLoad()
                .Cascade.All();
            HasMany(x => x.Solicitantes)
                .KeyColumn("gidexpediente")
                .Not.LazyLoad();
            HasMany(x => x.MotivosAdopcion)
                .KeyColumn("numero_instrumento")
                .Not.LazyLoad();
            Where("numero_expediente like 'SI-%'");   
        }
    }
}