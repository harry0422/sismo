using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using Dinaf.Sismo.Domain.MedidasProteccion.Entities;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.ConsolidacionFamiliar.Repositories
{
    public class ExpedienteNnaRepository : NhRepositoryBase<ExpedienteNna, int>, IExpedienteNnaRepository
    {
        public IList<ExpedienteNna> GetAll()
        {
            var nnaEstadoAdoptabilidad = Session.Query<MedidaProteccion>().Where(md => md.TipoCustodio.Id == 23).Select(x => x.NumeroExpediente).ToList();
            return Session.QueryOver<ExpedienteNna>()
                .WhereRestrictionOn(c => c.NumeroExpediente).IsIn(nnaEstadoAdoptabilidad)
                .List().OrderByDescending(x => x.FechaCreacion).ToList();
        }

        public ExpedienteNna GetByNumeroExpedienteNna(string numeroExpediente)
        {
            return Session.Query<ExpedienteNna>()
                .FirstOrDefault(x => x.NumeroExpediente == numeroExpediente);
        }
    }
}