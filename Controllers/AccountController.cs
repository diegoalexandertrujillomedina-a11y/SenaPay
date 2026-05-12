using Microsoft.AspNetCore.Mvc;

namespace Login_v2._0.Controllers
{
    public class AccountController : Controller
    {
        // Esta acción solo muestra la vista
        public IActionResult Index()
        {
            return View();
        }
        // Controlador de vistas "olvide contraseña" y "support"
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }
        public IActionResult CodVerificacion()
        {
            return View();
        }
        public IActionResult ActualizarContraseña()
        {
            return View();
        }
       
    }

}