using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories;
using Dinaf.Sismo.Infrastructure.Common;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Repositories
{
    public class EmparejamientoRepository : NhRepositoryBase<Emparejamiento, string>, IEmparejamientoRepository
    {

    }
}