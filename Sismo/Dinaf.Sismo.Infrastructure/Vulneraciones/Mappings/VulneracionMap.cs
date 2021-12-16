using Dinaf.Sismo.Domain.Vulneraciones.Entities;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;

namespace Dinaf.Sismo.Infrastructure.Vulneraciones.Mappings
{
    public class VulneracionMap : ClassMap<Vulneracion>
    {
        public VulneracionMap()
        {
            Table("expedientevulneracion");
            Id(x => x.Id, "id");
            Map(x => x.FechaCreacion, "fechacreacion");
            Map(x => x.UsuarioRemitente, "usuarioremitente");
            Map(x => x.NumeroInstrumento, "numero_instrumento");
            References(x => x.TipoVulneracion, "tipovulneracion")
                .Not.LazyLoad()
                .NotFound.Ignore();
        }
    }
}