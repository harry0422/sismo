using Dinaf.Sismo.Domain.Buzon.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Buzon.Mappings
{
    public class TipoGestionMap : ClassMap<TipoGestion>
    {
        public TipoGestionMap()
        {
            Table("tiposdegestion");
            Id(x => x.Id, "gidtiposdegestion");
            Map(x => x.Descripcion, "tiposdegestion");
        }
    }
}