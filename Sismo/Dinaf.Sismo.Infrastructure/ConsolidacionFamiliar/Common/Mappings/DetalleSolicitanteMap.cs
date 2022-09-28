using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class DetalleSolicitanteMap : ClassMap<DetalleSolicitante>
    {
        public DetalleSolicitanteMap()
        {
            Table("persona");
            Id(x => x.Id, "id");
            Map(x => x.Genero, "genero");
            Map(x => x.Estado, "estado");
            Map(x => x.FechaNacimiento, "fechanacimiento");
            Map(x => x.Nacionalidad, "ininacionalidad");
            Map(x => x.Ocupacion, "ocupacion");
            Map(x => x.Observaciones, "observaciones");
            Map(x => x.FotoPerfil, "foto_perfil");
            HasMany(x => x.Nombres).KeyColumn("gidpersona").Not.LazyLoad();
            HasMany(x => x.Relaciones).KeyColumn("gidpersona").Not.LazyLoad();
        }
    }
}