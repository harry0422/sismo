using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Personas.Mappings
{
    public class NombreMap : ClassMap<Nombre>
    {
        public NombreMap()
        {
            Table("personanombres");
            Id(x => x.Id, "id");
            Map(x => x.PrimerNombre, "nombre");
            Map(x => x.SegundoNombre, "segnombre");
            Map(x => x.PrimerApellido, "apellido");
            Map(x => x.SegundoApellido, "segapellido");
            Map(x => x.TipoNombre, "gidtiponombres");
            References(x => x.DetallePersona, "gidpersona");
        }
    }
}