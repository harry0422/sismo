using Dinaf.Sismo.Domain.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Personas.Mappings
{
    public class PersonaMap : ClassMap<Persona>
    {
        public PersonaMap()
        {
            Table("persona");
            Id(x => x.Id, "id");
            HasMany(x => x.Nombres)
                .KeyColumn("gidpersona")
                .Not.LazyLoad();
            Map(x => x.Genero, "genero");
            Map(x => x.Nna, "nna");
            Map(x => x.Raza, "raza");
            Map(x => x.Estado, "estado");
            Map(x => x.Cobertura, "cobertura");
            Map(x => x.Religion, "religion");
            Map(x => x.FechaNacimiento, "fechanacimiento");
            Map(x => x.Nacionalidad, "ininacionalidad");
            Map(x => x.Fecha, "sfecha");
            Map(x => x.UsuarioId, "id_usuario");
            Map(x => x.ColorCabello, "colorcabello");
            Map(x => x.ColorOjos, "colorojos");
            Map(x => x.ColorPiel, "colorpiel");
            Map(x => x.SignosFisicos, "signosfisicos");
            Map(x => x.Edad, "edad");
            Map(x => x.Ocupacion, "ocupacion");
            Map(x => x.Observaciones, "observaciones");
            Map(x => x.ChildrenFirst, "childrefirst");
        }
    }
}