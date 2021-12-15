namespace Dinaf.Sismo.Application.Personas.DTOs
{
    public class ExpedienteDto
    {
        public int Id { get; set; }
        public virtual PersonaDto Persona { get; set; }
        public string NumeroExpediente { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual string Fecha { get; set; }
        public virtual string EnCalidad { get; set; }
        public virtual string ExpNna { get; set; }
        public virtual string Estado { get; set; }
        public virtual string FechaEstado { get; set; }
        public virtual string ClaveTemporal { get; set; }
        public virtual string Asunto { get; set; }
    }
}