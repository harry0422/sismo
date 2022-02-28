using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Mappings
{
    public class MotivoAdopcionMap : ClassMap<MotivoAdopcion>
    {
        public MotivoAdopcionMap()
        {
            Table("expedientesanexos");
            Id(x => x.Id, "id");
            Map(x => x.FechaCreacion, "fechacreacion");
            Map(x => x.Contenido, "contenido");
            Map(x => x.NumeroExpediente, "numero_instrumento");
            Where("asunto = 'Adopción'");
        }
    }
}