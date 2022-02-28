using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class ExpedienteNnaMap : ClassMap<ExpedienteNna>
    {
        public ExpedienteNnaMap()
        {
            Table("personasexpediente");
            Id(x => x.Id, "gidexpediente");
            Map(x => x.FechaCreacion, "fecha");
            References(x => x.DetalleNna, "gidpersona").Not.LazyLoad();
            HasOne(x => x.CondicionMedica).ForeignKey("numero_expediente").Not.LazyLoad();
            Where("expnna = 'nna'");
        }
    }
}