using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class RelacionMap : ClassMap<Relacion>
    {
        public RelacionMap()
        {
            Table("personarelacion");
            Id(x => x.Id, "id");
            Map(x => x.Estado, "envida");
            References(x => x.TipoParentesco, "gidtipoparentesco").Not.LazyLoad();
        }
    }
}