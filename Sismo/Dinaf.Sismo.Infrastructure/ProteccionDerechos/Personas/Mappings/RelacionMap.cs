using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Personas.Mappings
{
    public class RelacionMap : ClassMap<Relacion>
    {
        public RelacionMap()
        {
            Table("personarelacion");
            Id(x => x.Id, "id");
            Map(x => x.Estado, "envida");
            Map(x => x.CorrelativoInstrumento, "correlativo_instrumento");
            References(x => x.TipoParentesco, "gidtipoparentesco").Not.LazyLoad();
        }
    }
}