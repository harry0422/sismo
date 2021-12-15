using Dinaf.Sismo.Domain.Personas.Entities;
using FluentNHibernate.Mapping;

namespace Dinaf.Sismo.Infrastructure.Personas.Mappings
{
    public class ExpedienteMap : ClassMap<PersonaExpediente>
    {
        public ExpedienteMap()
        {
            Table("personasexpediente");
            Id(x => x.Id, "id");
            References(x => x.Persona, "gidpersona").Not.LazyLoad();
            Map(x => x.NumeroExpediente, "gidexpediente");
            Map(x => x.UsuarioId, "id_usuario");
            Map(x => x.Fecha, "fecha");
            Map(x => x.Encalidad, "encalidad");
            Map(x => x.ExpNna, "expnna");
            Map(x => x.Estado, "estado");
            Map(x => x.FechaEstado, "sfechaestado");
            Map(x => x.ClaveTemporal, "clavetemporal");
            Map(x => x.Asunto, "asunto");
        }
    }
}