using Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Expedientes.Mappings
{
    public class ExpedienteMap : ClassMap<Expediente> 
    {
        public ExpedienteMap()
        {
            Table("expediente");
            Id(x => x.NumeroExpediente, "numero_expediente");
            Map(x => x.FechaCreacion, "fechacreacion");
            Map(x => x.Unidad, "gidunidades");
            Map(x => x.Usuario, "id_usuario");
            Map(x => x.TipoInstrumento, "tiposinstrumentos");
            Map(x => x.UnidadApertura, "unidadapertura");
            Map(x => x.NumeroAnterior, "numanterior");
            Map(x => x.Estado, "estado");
            Map(x => x.UsusarioAsignado, "userasignado");
        }
    }
}
