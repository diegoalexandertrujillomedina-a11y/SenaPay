using System.ComponentModel.DataAnnotations;

namespace SenaPay_Base.Models
{
    public class NuevaPasswordViewModel
    {
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public string NuevaPassword { get; set; }

        [Required(ErrorMessage = "La confirmación es obligatoria")]
        [DataType(DataType.Password)]
        [Compare("NuevaPassword", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmarPassword { get; set; }

    }
}
