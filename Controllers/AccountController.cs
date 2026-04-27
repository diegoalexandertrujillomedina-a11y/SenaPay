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
    }
}