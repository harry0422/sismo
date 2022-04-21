using Dinaf.Sismo.Domain.Buzon.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Buzon.Mappings
{
    public class CasoMap : ClassMap<Caso>
    {
        public CasoMap()
        {
            Table("casos");
            Id(x => x.Id, "id");
            Map(x => x.UsuarioApertura, "usuarioapertura");
            Map(x => x.UnidadApertura, "gidunidades");
            Map(x => x.Estado, "estado");
            References(x => x.TipoGestion, "gidtiposdegestion");
            Map(x => x.NumeroInstrumento, "numero_instrumento");
            Map(x => x.FechaCreacion, "fechacreacion");
            Map(x => x.UnidadDestino, "gidunidaddestino");
            Map(x => x.UsuarioAsignado, "usuarioasignado");
            HasMany(x => x.Mensajes)
                .KeyColumn("gidcasos")
                .Not.LazyLoad()
                .Cascade.All();
        }
    }
}
