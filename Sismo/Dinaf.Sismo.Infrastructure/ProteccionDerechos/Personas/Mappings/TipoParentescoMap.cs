using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Personas.Mappings
{
    public class TipoParentescoMap : ClassMap<TipoParentesco>
    {
        public TipoParentescoMap()
        {
            Table("tipoparentesco");
            Id(x => x.Id, "gidtipoparentesco");
            Map(x => x.Descripcion, "parentesco");
        }
    }
}