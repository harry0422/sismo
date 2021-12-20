using Dinaf.Sismo.Domain.Vulneraciones.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Vulneraciones.Mappings
{
    public class SubTipoVulneracionMap : ClassMap<SubTipoVulneracion>
    {
        public SubTipoVulneracionMap()
        {
            Table("tipovulneracionhijo");
            Id(x => x.Id, "id");
            Map(x => x.Tipologia, "tipologia");
            References(x => x.TipoVulneracion, "gidtipovulneracion").Not.LazyLoad();
        }
    }
}