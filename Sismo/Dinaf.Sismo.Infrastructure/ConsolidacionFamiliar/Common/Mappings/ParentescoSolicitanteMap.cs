using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class ParentescoSolicitanteMap : ClassMap<ParentescoSolicitante>
    {
        public ParentescoSolicitanteMap()
        {
            Table("tipoparentesco");
            Id(x => x.Id, "gidtipoparentesco");
            Map(x => x.Descripcion, "parentesco");
        }
    }
}