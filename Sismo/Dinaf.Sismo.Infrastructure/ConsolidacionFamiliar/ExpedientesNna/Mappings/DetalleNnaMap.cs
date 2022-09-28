using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class DetalleNnaMap : ClassMap<DetalleNna>
    {
        public DetalleNnaMap()
        {
            Table("persona");
            Id(x => x.Id, "id");
            Map(x => x.Genero, "genero");
            Map(x => x.Raza, "raza");
            Map(x => x.Religion, "religion");
            Map(x => x.FechaNacimiento, "fechanacimiento");
            Map(x => x.Nacionalidad, "ininacionalidad");
            Map(x => x.ColorCabello, "colorcabello");
            Map(x => x.ColorOjos, "colorojos");
            Map(x => x.ColorPiel, "colorpiel");
            Map(x => x.SignosFisicos, "signosfisicos");
            Map(x => x.Ocupacion, "ocupacion");
            Map(x => x.CondicionMedica, "condicion_medica");
            Map(x => x.FotoPerfil, "foto_perfil");
            HasMany(x => x.Nombres)
                .KeyColumn("gidpersona")
                .Not.LazyLoad();
            HasMany(x => x.Relaciones)
                .KeyColumn("gidpersona")
                .Not.LazyLoad();
        }
    }
}