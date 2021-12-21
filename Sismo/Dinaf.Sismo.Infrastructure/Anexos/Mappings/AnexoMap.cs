using Dinaf.Sismo.Domain.Anexos.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Anexos.Mappings
{
    public class AnexoMap : ClassMap<Anexo>
    {
        public AnexoMap()
        {
            Table("expedientesanexos");
            Id(x => x.Id, "id");
            Map(x => x.FechaCreacion, "fechacreacion");
            Map(x => x.Asunto, "asunto");
            Map(x => x.Contenido, "contenido");
            Map(x => x.UsuarioRemitente, "usuarioremitente");
            Map(x => x.NumeroExpediente, "numero_instrumento");
            Map(x => x.Responsable, "responsable");
            Map(x => x.UnidadRemitente, "unidadremitente");
        }
    }
}