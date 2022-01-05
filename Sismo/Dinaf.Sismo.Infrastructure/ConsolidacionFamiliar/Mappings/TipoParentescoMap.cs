using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class TipoParentescoMap : ClassMap<TipoParentesco>
    {
        public TipoParentescoMap()
        {
            Table("tipoparentesco");
            Id(x => x.Id, "gidtipoparentesco");
            Map(x => x.Descripcion, "parentesco");
        }
    }
}