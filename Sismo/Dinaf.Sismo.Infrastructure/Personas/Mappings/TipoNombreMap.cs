using Dinaf.Sismo.Domain.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Personas.Mappings
{
    public class TipoNombreMap : ClassMap<TipoNombre>
    {
        public TipoNombreMap()
        {
            Table("tiponombres");
            Id(x => x.Id, "gidtiponombres");
            Map(x => x.Valor, "tiponombres");
        }
    }
}