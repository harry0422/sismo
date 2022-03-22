using Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes;
using Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.ProteccionDerechos.Expedientes.Repositories
{
    public class ExpedienteRepository : NhRepositoryBase<Expediente, int>, IExpedienteRepository
    {
        public IList<Expediente> GetExpedientesByTipo(string tipoInstrumento)
        {
            return Session.Query<Expediente>().Where(x => x.TipoInstrumento == tipoInstrumento).ToList();
        }

        public Expediente GetExpedienteByNumeroExpediente(string numeroExpediente)
        {
            return Session.Query<Expediente>().FirstOrDefault(x => x.NumeroExpediente == numeroExpediente);
        }
    }
}