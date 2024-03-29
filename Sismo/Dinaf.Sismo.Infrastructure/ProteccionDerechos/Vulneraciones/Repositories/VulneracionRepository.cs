﻿using Dinaf.Sismo.Domain.Vulneraciones.Entities;
using Dinaf.Sismo.Domain.Vulneraciones.Repositories;
using Dinaf.Sismo.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Infrastructure.Vulneraciones.Repositories
{
    public class VulneracionRepository : NhRepositoryBase<Vulneracion, int>, IVulneracionRepository
    {
        public IList<Vulneracion> GetByNumeroExpediente(string numeroExpediente)
        {
            return Session.Query<Vulneracion>()
                .Where(x => x.NumeroInstrumento == numeroExpediente)
                .OrderByDescending(x => x.FechaCreacion)
                .ToList();
        }

        public IList<Vulneracion> GetBySubTipo(int subTipoVulneracionId)
        {
            return Session.Query<Vulneracion>()
                .Where(x => x.SubTipoVulneracion.Id == subTipoVulneracionId)
                .OrderByDescending(x => x.FechaCreacion)
                .ToList();
        }
    }
}