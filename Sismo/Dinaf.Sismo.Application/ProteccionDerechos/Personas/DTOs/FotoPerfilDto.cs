namespace Dinaf.Sismo.Application.ProteccionDerechos.Personas.DTOs
{
    public class FotoPerfilDto
    {
        public FotoPerfilDto(int personaId, string rutaCarpeta, string fotoBase64, string formato)
        {
            PersonaId = personaId;
            RutaCarpeta = rutaCarpeta;
            FotoBase64 = fotoBase64;
            Formato = formato;
        }

        public int PersonaId { get; set; }
        public string RutaCarpeta { get; set; }
        public string FotoBase64 { get; set; }
        public string Formato { get; set; }
    }
}