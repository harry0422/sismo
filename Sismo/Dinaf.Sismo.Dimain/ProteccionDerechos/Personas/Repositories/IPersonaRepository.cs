using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Personas.Repositories
{
    public interface IPersonaRepository : IRepository<Persona, int>
    {
        IList<Persona> GetPersonasByExpediente(string numeroExpediente);
    }
}