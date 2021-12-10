using Dinaf.Sismo.Domain.Expedientes.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinaf.Sismo.Infrastructure.Expedientes.Mappings
{
    public class PersonaExpedienteMap : ClassMap<PersonaExpediente>
    {
        public PersonaExpedienteMap()
        {
            Table("personasexpediente");
            Id(x => x.Id, "id");
            References(x => x.Persona, "gidpersona");
            References(x => x.Expediente, "gidexpediente");
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
