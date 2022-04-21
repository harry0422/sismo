using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Personas.Mappings
{
    public class PersonaMap : ClassMap<Persona>
    {
        public PersonaMap()
        {
            Table("personasexpediente");
            Id(x => x.Id, "id");
            References(x => x.DetallePersona, "gidpersona").Not.LazyLoad();
            Map(x => x.NumeroExpediente, "gidexpediente");
            Map(x => x.UsuarioCreacion, "id_usuario");
            Map(x => x.FechCreaciona, "fecha");
            Map(x => x.EnCalidad, "encalidad");
            Map(x => x.Nna, "expnna");
        }
    }
}
