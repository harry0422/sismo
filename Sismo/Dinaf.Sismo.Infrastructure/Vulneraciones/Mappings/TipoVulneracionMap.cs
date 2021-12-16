using Dinaf.Sismo.Domain.Vulneraciones.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Vulneraciones.Mappings
{
    public class TipoVulneracionMap : ClassMap<TipoVulneracion>
    {
        public TipoVulneracionMap()
        {
            Table("tipovulneracion");
            Id(x => x.Id, "id");
            Map(x => x.Artuculo, "articulo");
            Map(x => x.Tipologia, "tipologia");
        }
    }
}