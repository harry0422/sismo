using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.Personas.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Personas.Repositories
{
    public interface IExpedienteRepository : IRepository<PersonaExpediente, int>
    {
        IList<PersonaExpediente> GetExpedientesNiños();
        IList<PersonaExpediente> GetExpedientesAdultos();
    }
}