using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Mappings
{
    public class EmparejamientoMap : ClassMap<Emparejamiento>
    {
        public EmparejamientoMap()
        {
            Table("emparejamientos");
            Id(x => x.Id, "id");
            Map(x => x.ExpedienteNna, "expediente_nna");
            Map(x => x.SolicitudAdopcion, "solicitud_adopcion");
            Map(x => x.Etapa, "etapa");
            HasMany(x => x.Seguimientos)
                .KeyColumn("emparejamiento_id")
                .Cascade.All()
                .Not.LazyLoad();
        }
    }
}