using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Mappings
{
    public class NnaEmparejamientoMap : ClassMap<NnaEmparejamiento>
    {
        public NnaEmparejamientoMap()
        {
            Table("expediente");
            Id(x => x.Id, "numero_expediente");
            HasMany(x => x.Emparejamientos)
                .KeyColumn("expediente_nna")
                .Not.LazyLoad();
        }
    }
}