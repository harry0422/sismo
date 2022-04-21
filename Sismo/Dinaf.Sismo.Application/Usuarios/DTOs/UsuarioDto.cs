namespace Dinaf.Sismo.Application.Usuarios.DTOs
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Perfil { get; set; }
        public string NombreUsuario { get; set; }
        public int Unidad { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
    }
}