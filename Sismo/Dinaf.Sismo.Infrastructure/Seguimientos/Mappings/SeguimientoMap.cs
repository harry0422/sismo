using Dinaf.Sismo.Domain.Seguimientos.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Seguimientos.Mappings
{
    public class SeguimientoMap : ClassMap<Seguimiento>
    {
        public SeguimientoMap()
        {
            Table("seguimiento");
            Id(x => x.Id, "id");
            Map(x => x.NumeroExpediente, "numero_instrumento");
            //References(x => x.TipoCustodio, "gidtipocustodio").Not.LazyLoad().NotFound.Ignore();
            Map(x => x.FechaInicio, "fechainicio");
            Map(x => x.FechaFinal, "fechafinal");
            Map(x => x.Referencias, "referencias");
            Map(x => x.UsuarioRemitente, "usuarioremitente");
            Map(x => x.TipoGestion, "tipogestion");
            Map(x => x.Estado, "estado");
            Map(x => x.UnidadRemitente, "unidadremitente");
        }
    }
}