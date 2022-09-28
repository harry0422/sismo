using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Personas.Mappings
{
    public class DetallePersonaMap : ClassMap<DetallePersona>
    {
        public DetallePersonaMap()
        {
            Table("persona");
            Id(x => x.Id, "id");
            Map(x => x.Genero, "genero");
            Map(x => x.Nna, "nna");
            Map(x => x.Raza, "raza");
            Map(x => x.Religion, "religion");
            Map(x => x.FechaNacimiento, "fechanacimiento");
            Map(x => x.Nacionalidad, "ininacionalidad");
            Map(x => x.Usuario, "id_usuario");
            Map(x => x.ColorCabello, "colorcabello");
            Map(x => x.ColorOjos, "colorojos");
            Map(x => x.ColorPiel, "colorpiel");
            Map(x => x.SignosFisicos, "signosfisicos");
            Map(x => x.Ocupacion, "ocupacion");
            Map(x => x.Observaciones, "observaciones");
            Map(x => x.FotoPerfil, "foto_perfil");
            HasOne(x => x.Nombre).PropertyRef("DetallePersona")
                .Cascade.All()
                .Not.LazyLoad();
            HasMany(x => x.Relaciones).KeyColumn("gidpersona")
                .Cascade.All()
                .Not.LazyLoad();
        }
    }
}