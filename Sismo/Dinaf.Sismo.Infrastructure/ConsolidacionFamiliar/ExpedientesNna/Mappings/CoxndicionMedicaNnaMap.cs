using Dinaf.Sismo.Domain.ConsolidacionFamiliar.ExpedientesNna.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.ExpedientesNna.Mappings
{
    public class CoxndicionMedicaNnaMap : ClassMap<CondicionMedicaNna>
    {
        public CoxndicionMedicaNnaMap()
        {
            Table("condiciones_medicas_nna");
            Id(x => x.Id, "numero_expediente");
            References(x => x.CondicionMedica, "condicion_medica");
        }
    }
}