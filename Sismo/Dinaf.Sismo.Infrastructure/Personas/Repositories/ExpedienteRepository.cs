using Dinaf.Sismo.Domain.Personas.Entities;
using Dinaf.Sismo.Domain.Personas.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.Personas.Repositories
{
    public class ExpedienteRepository : NhRepositoryBase<PersonaExpediente, int>, IExpedienteRepository
    {
        public IList<PersonaExpediente> GetExpedientesNiños()
        {
            return Session.Query<PersonaExpediente>().Where(x => x.ExpNna == "nna").ToList();
        }

        public IList<PersonaExpediente> GetSolicitantesAdopcion()
        {
            return Session.Query<PersonaExpediente>()
                .Where(x => x.NumeroExpediente.Substring(0, 3) == "SI-" && x.Persona != null).ToList();
        }
    }
}