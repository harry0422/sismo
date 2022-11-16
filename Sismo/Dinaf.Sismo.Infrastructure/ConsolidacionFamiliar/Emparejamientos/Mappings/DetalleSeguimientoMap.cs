using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Mappings
{
    public class DetalleSeguimientoMap : ClassMap<DetalleSeguimiento>
    {
        public DetalleSeguimientoMap()
        {
            Table("seguimiento_emparejamientos");
            Id(x => x.Id, "id");
            Map(x => x.Etapa, "etapa");
            Map(x => x.Fecha, "fecha");
            Map(x => x.Observaciones, "observaciones");
            Map(x => x.Usuario, "usuario");
            Map(x => x.Adjunto, "adjunto");
            References(x => x.Emparejamiento).Not.LazyLoad();
        }
    }
}