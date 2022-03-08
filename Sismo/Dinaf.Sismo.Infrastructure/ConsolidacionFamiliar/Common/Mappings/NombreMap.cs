using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Common;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
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
        }
    }
}