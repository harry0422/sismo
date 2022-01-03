using Dinaf.Sismo.Application.ConsolidacionFamiliar.DTOs;
using Dinaf.Sismo.Application.Contracts.Personas;
using Dinaf.Sismo.Application.Vulneraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using TipoVulneracionId = Dinaf.Sismo.Application.Vulneraciones.DTOs.TipoVulneracionIdDto;
using Vulneracion = Dinaf.Sismo.Application.Vulneraciones.DTOs.VulneracionDto;
using NumeroExpedientePersona = Dinaf.Sismo.Application.Personas.DTOs.NumeroExpedienteDto;
using ExpedientePersona = Dinaf.Sismo.Application.Personas.DTOs.ExpedienteDto;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar
{
    public class ConsolidacionFamiliarService : IConsolidacionFamiliarService
    {
        private const int ID_DECLARACION_ABANDONO = 41;

        private readonly IVulneracionService _vulneracionService;
        private readonly IPersonaService _personaService;

        public List<NnaEstadoAdoptabilidadDto> GetNnaEstadoAdoptabilidad()
        {
             
            //List<Vulneracion> vulneraciones = _vulneracionService.GetVulneraciones(new TipoVulneracionId(ID_DECLARACION_ABANDONO));
            //List<NumeroExpedientePersona> numerosExpedientes = new List<NumeroExpedientePersona>();
            //vulneraciones.ForEach(vulneracion => numerosExpedientes.Add(new NumeroExpedientePersona(vulneracion.NumeroInstrumento)));

            //List<ExpedientePersona> expedientes = _personaService.GetExpedientesNiños(numerosExpedientes);




            throw new NotImplementedException();
        }



        public void AddCaracteristicasAdopcion(CaracteristicasAdopcionDto caracteristicasAdopcion)
        {
            throw new NotImplementedException();
        }

        public void GetAdultosParaPosiblesEmparejamientos(NumeroExpedienteDto numeroExpediente)
        {
            throw new NotImplementedException();
        }

        public void GetNiñosParaPosiblesEmparejamientos(NumeroExpedienteDto numeroExpediente)
        {
            throw new NotImplementedException();
        }

        

        public List<SolicitudDeAdopcionDto> GetSolicitudesAdopcion()
        {
            throw new NotImplementedException();
        }
    }
}
