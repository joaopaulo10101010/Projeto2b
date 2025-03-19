using Microsoft.AspNetCore.Mvc;

namespace Projeto2B.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
