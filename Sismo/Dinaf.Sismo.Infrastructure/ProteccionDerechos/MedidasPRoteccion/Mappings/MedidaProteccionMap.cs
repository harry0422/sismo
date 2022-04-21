using Dinaf.Sismo.Domain.MedidasProteccion.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.MedidasProteccion.Mappings
{
    public class MedidaProteccionMap : ClassMap<MedidaProteccion>
    {
        public MedidaProteccionMap()
        {
            Table("seguimiento");
            Id(x => x.Id, "id");
            Map(x => x.NumeroExpediente, "numero_instrumento");
            Map(x => x.FechaInicio, "fechainicio");
            Map(x => x.FechaFinal, "fechafinal");
            Map(x => x.Referencias, "referencias");
            Map(x => x.UsuarioRemitente, "usuarioremitente");
            Map(x => x.TipoGestion, "tipogestion");
            Map(x => x.Estado, "estado");
            Map(x => x.UnidadRemitente, "unidadremitente");
            References(x => x.TipoCustodio, "gidtipocustodio").Not.LazyLoad();
        }
    }
}