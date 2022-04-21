using Dinaf.Sismo.Application.MedidasProteccion.Mappers;
using Dinaf.Sismo.Application.ProteccionDerechos.MedidasProteccion.DTOs;
using Dinaf.Sismo.Domain.MedidasProteccion.Entities;
using Dinaf.Sismo.Domain.MedidasProteccion.Repositories;
using System.Collections.Generic;

namespace Dinaf.Sismo.Application.MedidasProteccion
{
    public class MedidaProteccionService : IMedidaProteccionService
    {
        private readonly IMedidaProteccionRepository _medidaProteccionRepository;

        public MedidaProteccionService(IMedidaProteccionRepository seguimientoRepository)
        {
            _medidaProteccionRepository = seguimientoRepository;
        }

        public List<MedidaProteccionDto> GetMedidasProteccion(NumeroExpedienteDto numeroExpediente)
        {
            return _medidaProteccionRepository.GetByNumeroExpediente(numeroExpediente.Valor).ToDto();
        }

        public void AgregarMedidaProteccion(NuevaMedidaProteccionDto nuevaMedidaProteccion)
        {
            MedidaProteccion medidaProteccion = new MedidaProteccion();
        }
    }
}