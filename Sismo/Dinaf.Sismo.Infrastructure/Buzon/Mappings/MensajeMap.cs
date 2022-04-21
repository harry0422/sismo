using Dinaf.Sismo.Domain.Buzon.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Buzon.Mappings
{
    public class MensajeMap : ClassMap<Mensaje>
    {
        public MensajeMap()
        {
            Table("mesages");
            Id(x => x.Id, "id");
            Map(x => x.FechaCreacion, "fechacreacion");
            Map(x => x.FechaLeido, "fechaleido");
            Map(x => x.Remitente, "usuarioremitente");
            Map(x => x.Asunto, "asunto");
            Map(x => x.Contenido, "contenido");
            References(x => x.Caso, "gidcasos");
            Map(x => x.Tipo, "tipo");
            Map(x => x.UnidadDestino, "unidaddestino");
            Map(x => x.UnidadRemitente, "unidadremitente");
        }
    }
}