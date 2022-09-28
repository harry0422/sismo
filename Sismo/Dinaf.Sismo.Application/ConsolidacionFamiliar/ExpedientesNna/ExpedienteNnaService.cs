using Dinaf.Sismo.Application.ConsolidacionFamiliar.Common.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.Mappers;
using Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{

    public class ExpedienteNnaService : IExpedienteNnaService
    {
        private readonly IExpedienteNnaRepository _expedienteNnaRepository;

        public ExpedienteNnaService(IExpedienteNnaRepository expedienteNnaRepository)
        {
            _expedienteNnaRepository = expedienteNnaRepository;
        }

        public IList<ExpedienteNnaDto> GetNnaEstadoAdoptabilidad()
        {
            return _expedienteNnaRepository.GetAll().ToDto();
        }

        public ExpedienteNnaDto GetNnaEstadoAdoptabilidad(NumeroExpedienteNnaDto numeroExpediente)
        {
            return _expedienteNnaRepository.GetByNumeroExpedienteNna(numeroExpediente.Valor).ToDto();
        }

        public void AddCaracteristicas(CaracteristicasDto caracteristicas)
        {
            ExpedienteNna expedienteNna = _expedienteNnaRepository.Get(caracteristicas.Persona);
            expedienteNna.DetalleNna.Raza = caracteristicas.Raza;
            expedienteNna.DetalleNna.ColorCabello = caracteristicas.ColorCabello;
            expedienteNna.DetalleNna.ColorPiel = caracteristicas.ColorPiel;
            expedienteNna.DetalleNna.ColorOjos = caracteristicas.ColorOjos;
            expedienteNna.DetalleNna.CondicionMedica = caracteristicas.CondicionMedica;

            _expedienteNnaRepository.Update(expedienteNna);
        }
    }
}