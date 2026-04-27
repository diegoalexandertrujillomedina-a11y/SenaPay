using System.ComponentModel.DataAnnotations;

namespace LoginVistas.Models // O el namespace que estés usando actualmente
{
    public class LoginViewModel
    {
        public string Documento { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}