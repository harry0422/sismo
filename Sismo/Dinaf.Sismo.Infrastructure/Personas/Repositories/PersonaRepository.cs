using Dinaf.Sismo.Domain.Personas.Entities;
using Dinaf.Sismo.Domain.Personas.Repositories;
using Dinaf.Sismo.Infrastructure.Common;

namespace Dinaf.Sismo.Infrastructure.Personas.Repositories
{
    public class PersonaRepository : NhRepositoryBase<Persona, int>, IPersonaRepository
    {

    }
}