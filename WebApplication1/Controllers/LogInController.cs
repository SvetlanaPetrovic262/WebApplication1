using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
