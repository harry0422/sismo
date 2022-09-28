using Dinaf.Sismo.Domain.Common.Repositories;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.Emparejamientos.Repositories
{
    public interface ISeguimientoRepository : IRepository<DetalleSeguimiento, string>
    {
        public IList<DetalleSeguimiento> GetByEmparejamientoId(string emparejamientoId);
    }
}