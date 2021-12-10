using Dinaf.Sismo.Domain.Expedientes.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Expedientes.Mappings
{
    public class ExpedienteMap : ClassMap<Expediente>
    {
        public ExpedienteMap()
        {
            Table("expediente");
            Id(x => x.Id, "id");
            HasMany(x => x.PersonaExpedientes)
                .KeyColumn("gidexpediente")
                .Not.LazyLoad();
            Map(x => x.NumeroExpediente, "numero_expediente");
            Map(x => x.FechaCreacion, "fechacreacion");
            //Map(x => x.Id, "id");
            Map(x => x.Usuario, "id_usuario");
            Map(x => x.TipoInstrumento, "tiposinstrumentos");
            //Map(x => x.Id, "id");
            Map(x => x.Tipo, "tipo");
            Map(x => x.NumeroAnterior, "numanterior");
            Map(x => x.Estado, "estado");
            Map(x => x.AñoAnterior, "numanterioranio");
            Map(x => x.Procedencia, "procedencia");
            Map(x => x.Consentimiento, "consentimiento");
            Map(x => x.UsuarioAsignado, "userasignado");
            Map(x => x.SFecha, "sfecha");
            Map(x => x.Issue, "issue");
            Map(x => x.FechaVulneracion, "fehavulneracion");
        }
    }
}
