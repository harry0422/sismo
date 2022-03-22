using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class SolicitanteMap : ClassMap<Solicitante>
    {
        public SolicitanteMap()
        {
            Table("personasexpediente");
            Id(x => x.Id, "id");
            References(x => x.DetallePersona, "gidpersona").Not.LazyLoad();
            Map(x => x.NumeroExpediente, "gidexpediente");
            Map(x => x.Fecha, "fecha");
            Where("gidexpediente like 'SI-%'");
        }
    }
}