namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs
{
    public class VincularPersonaDto
    {
        public VincularPersonaDto(string numeroExpediente, int personaId, int usuarioCreacion, string enCalidad)
        {
            NumeroExpediente = numeroExpediente;
            PersonaId = personaId;
            UsuarioCreacion = usuarioCreacion;
            EnCalidad = enCalidad;
        }

        public string NumeroExpediente { get; set; }
        public int PersonaId { get; set; }
        public int UsuarioCreacion { get; set; }
        public string EnCalidad { get; set; }
    }
}