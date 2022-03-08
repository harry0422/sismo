using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class DetallePersonaMap : ClassMap<DetallePersona>
    {
        public DetallePersonaMap()
        {
            Table("persona");
            Id(x => x.Id, "id");
            Map(x => x.Genero, "genero");
            Map(x => x.Estado, "estado");
            Map(x => x.FechaNacimiento, "fechanacimiento");
            Map(x => x.Nacionalidad, "ininacionalidad");
            Map(x => x.Ocupacion, "ocupacion");
            Map(x => x.Observaciones, "observaciones");
            HasOne(x => x.Nombre).ForeignKey("gidpersona").Not.LazyLoad();
            HasMany(x => x.Relaciones).KeyColumn("gidpersona").Not.LazyLoad();
        }
    }
}