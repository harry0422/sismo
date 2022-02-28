using Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.CondicionesMedicas.Mappings
{
    public class CondicionMedicaMap : ClassMap<CondicionMedica>
    {
        public CondicionMedicaMap()
        {
            Table("condiciones_medicas");
            Id(x => x.Id, "id");
            Map(x => x.Descripcion, "descripcion");
        }
    }
}