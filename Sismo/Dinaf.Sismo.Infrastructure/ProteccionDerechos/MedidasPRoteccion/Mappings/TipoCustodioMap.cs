using Dinaf.Sismo.Domain.MedidasProteccion.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.MedidasProteccion.Mappings
{
    public class TipoCustodioMap : ClassMap<TipoCustodio>
    {
        public TipoCustodioMap()
        {
            Table("tipocustodio");
            Id(x => x.Id, "gidtipocustodio");
            Map(x => x.Nombre, "tipocustodio");
            Map(x => x.Descripcion, "descripcion");
        }
    }
}