using Dinaf.Sismo.Application.ConsolidacionFamiliar.ExpedientesNna.DTOs;
using Dinaf.Sismo.Domain.ConsolidacionFamiliar.Entities;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Mappers
{
    public static class DetalleNnaMapper
    {
        public static DetalleNnaDto ToDto(this DetalleNna detalleNna)
        {
            if (detalleNna is null) return null;

            DetalleNnaDto dto = new DetalleNnaDto();
            dto.Id = detalleNna.Id;
            dto.Nombre = detalleNna.NombreCompleto;
            dto.NombreCorto = detalleNna.NombreCorto;
            dto.Genero = detalleNna.Genero;
            dto.Edad = detalleNna.Edad;
            dto.Raza = detalleNna.Raza;
            dto.Religion = detalleNna.Religion;
            dto.FechaNacimiento = detalleNna.FechaNacimiento.ToString("dd/MM/yyyy");
            dto.Nacionalidad = detalleNna.Nacionalidad;
            dto.ColorCabello = detalleNna.ColorCabello;
            dto.ColorOjos = detalleNna.ColorOjos;
            dto.ColorPiel = detalleNna.ColorPiel;
            dto.CondicionMedica = detalleNna.CondicionMedica;
            dto.SignosFisicos = detalleNna.SignosFisicos;
            dto.Ocupacion = detalleNna.Ocupacion;
            dto.FotoPerfil = detalleNna.FotoPerfil;

            return dto;
        }
    }
}