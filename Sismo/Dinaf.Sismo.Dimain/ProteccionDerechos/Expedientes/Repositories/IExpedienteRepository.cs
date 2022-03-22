using Dinaf.Sismo.Domain.Common.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.ProteccionDerechos.Expedientes.Repositories
{
    public interface IExpedienteRepository : IRepository<Expediente, int>
    {
        public IList<Expediente> GetExpedientesByTipo(string tipoExpediente);
        public Expediente GetExpedienteByNumeroExpediente(string numeroExpediente);
    }
}