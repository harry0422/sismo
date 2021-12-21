using Dinaf.Sismo.Application.Contracts.Personas;
using Dinaf.Sismo.Application.Personas.DTOs;
using Dinaf.Sismo.Application.Personas.Mappers;
using Dinaf.Sismo.Application.Seguimientos;
using Dinaf.Sismo.Application.Seguimientos.DTOs;
using Dinaf.Sismo.Application.Vulneraciones;
using Dinaf.Sismo.Application.Vulneraciones.DTOs;
using Dinaf.Sismo.Domain.Personas.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.Implementation.Personas
{
    public class PersonaService : IPersonaService
    {
        private const int ID_DECLARACION_ABANDONO = 41;

        private readonly IPersonaRepository _personaRepository;
        private readonly IExpedienteRepository _expedienteRepository;
        private readonly IVulneracionService _vulneracionService;

        public PersonaService(IPersonaRepository personaRepository, IExpedienteRepository expedienteRepository, IVulneracionService vulneracionService)
        {
            _personaRepository = personaRepository;
            _expedienteRepository = expedienteRepository;
            _vulneracionService = vulneracionService;
        }

        public ListPersonasDto GetPersonas()
        {
            return _personaRepository.GetAll().ToDto();
        }

        public PersonaDto GetPersona(PersonaIdDto personaId)
        {
            return _personaRepository.Get(personaId.Valor).ToDto();
        }

        public ListExpedientesDto GetExpedientes()
        {
            return _expedienteRepository.GetAll().ToDto();
        }

        public ExpedienteDto GetExpediente(PersonaExpedienteIdDto expedienteId)
        {
            return _expedienteRepository.Get(expedienteId.Valor).ToDto();
        }

        public ListExpedientesDto GetNnaEstadoAdoptabilidad()
        {
            ListVulneracionesDto vulneraciones = _vulneracionService.GetVulneraciones(new TipoVulneracionIdDto(ID_DECLARACION_ABANDONO));
            
            return _expedienteRepository
                .GetExpedientesNiños(vulneraciones.Vulneraciones.Select(x => x.NumeroInstrumento).ToList())
                .ToDto();
        }

        public ListExpedientesDto GetSolicitantesAdopcion()
        {
            return _expedienteRepository.GetSolicitantesAdopcion().ToDto();
        }
    }
}