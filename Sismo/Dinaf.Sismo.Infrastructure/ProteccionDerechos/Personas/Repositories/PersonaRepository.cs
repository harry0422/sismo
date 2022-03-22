using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Personas.Repositories
{
    public class PersonaRepository : NhRepositoryBase<Persona, int>, IPersonaRepository
    {
        public IList<Persona> GetPersonasByExpediente(string numeroExpediente)
        {
            return Session.Query<Persona>().Where(x => x.NumeroExpediente == numeroExpediente).ToList();
        }
    }
}