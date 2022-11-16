using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Emparejamientos.Repositories
{
    public class DetalleSeguimientoRepository : NhRepositoryBase<DetalleSeguimiento, string>, ISeguimientoRepository
    {
        IList<DetalleSeguimiento> ISeguimientoRepository.GetByEmparejamientoId(string emparejamientoId)
        {
            return Session.Query<DetalleSeguimiento>().Where(x => x.Emparejamiento.Id == emparejamientoId).ToList();
        }
    }
}