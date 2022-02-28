using Dinaf.Sismo.Domain.Common.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.CondicionesMedicas.Entities;
using System;

namespace Dinaf.Sismo.Domain.ConsolidacionFamiliar.ExpedientesNna.Entities
{
    public class CondicionMedicaNna : EntityBase<string>
    {
        public CondicionMedicaNna() { }

        public CondicionMedicaNna(string numeroExpediente, CondicionMedica condicionMedica)
        {
            Id = numeroExpediente;
            CondicionMedica = condicionMedica;
        }

        public virtual CondicionMedica CondicionMedica { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}