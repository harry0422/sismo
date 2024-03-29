﻿using System;

namespace Dinaf.Sismo.Application.ConsolidacionFamiliar.Emparejamientos.DTOs
{
    public class InformacionSeguimientoDto
    {
        public string Id { get; set; }
        public string ExpedienteNna { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string NombreArchivo { get; set; }
        public string Base64 { get; set; }
        public string RutaCarpeta { get; set; }
    }
}