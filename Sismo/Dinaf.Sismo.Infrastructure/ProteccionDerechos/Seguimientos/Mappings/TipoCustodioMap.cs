using Dinaf.Sismo.Domain.Seguimientos.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Seguimientos.Mappings
{
    public class TipoCustodioMap : ClassMap<TipoCustodio>
    {
        public TipoCustodioMap()
        {
            Table("tipocustodio");
            Id(x => x.Id, "id");
            Map(x => x.Nombre, "tipocustodio");
            Map(x => x.Descripcion, "descripcion");
        }
    }
}