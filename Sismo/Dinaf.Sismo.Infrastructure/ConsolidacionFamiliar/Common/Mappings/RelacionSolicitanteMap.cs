using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class RelacionSolicitanteMap : ClassMap<RelacionSolicitante>
    {
        public RelacionSolicitanteMap()
        {
            Table("personarelacion");
            Id(x => x.Id, "id");
            Map(x => x.Estado, "envida");
            References(x => x.TipoParentesco, "gidtipoparentesco").Not.LazyLoad();
        }
    }
}