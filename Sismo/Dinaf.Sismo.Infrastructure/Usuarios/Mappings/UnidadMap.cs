using Dinaf.Sismo.Domain.Usuarios.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Usuarios.Mappings
{
    public class UnidadMap : ClassMap<Unidad>
    {
        public UnidadMap()
        {
            Table("unidades");
            Id(x => x.Id, "gidunidades");
            Map(x => x.Descripcion, "unidad");
            Map(x => x.Centro, "gidcentros");
            Map(x => x.Tipo, "tipo");
            Map(x => x.EstadoUnidad, "\"estadoUnidad\"");
        }
    }
}