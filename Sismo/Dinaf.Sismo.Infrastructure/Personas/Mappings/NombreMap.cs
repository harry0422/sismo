using Dinaf.Sismo.Domain.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Personas.Mappings
{
    public class NombreMap : ClassMap<Nombre>
    {
        public NombreMap()
        {
            Table("personanombres");
            Id(x => x.Id, "id");
            References(x => x.TipoNombre, "gidtiponombres");
            Map(x => x.PrimerNombre, "nombre");
            Map(x => x.SegundoNombre, "segnombre");
            Map(x => x.PrimerApellido, "apellido");
            Map(x => x.SegundoApellido, "segapellido");
            Map(x => x.CorrelativoInstrumento, "correlativo_instrumento");
            Map(x => x.Fecha, "sfecha");
            Map(x => x.UsuarioId, "id_usuario");
            Map(x => x.NombreCompleto, "completename");
        }
    }
}